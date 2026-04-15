using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Quartz;
using TetPee.Repository;

namespace TetPee.Service.BackgroundJobService;

[DisallowConcurrentExecution]//không cho con job chạy song song
//tránh hiện tượng 2 con update cùng dữ liệu
public class ProcessTransactionPendingJob : IJob
{
    private const string PendingStatus = "Pending";
    private const string CancelledStatus = "Cancelled";
    private static readonly TimeSpan DefaultPendingTimeout = TimeSpan.FromMinutes(2);//thời gian timeout

    private readonly AppDbContext _dbContext;
    private readonly ILogger<ProcessTransactionPendingJob> _logger;

    public ProcessTransactionPendingJob(
        AppDbContext dbContext,
        ILogger<ProcessTransactionPendingJob> logger)
    {
        _dbContext = dbContext;
        _logger = logger;
    }

    public async Task Execute(IJobExecutionContext context)
    {
        var pendingTimeoutMinutes = (int)DefaultPendingTimeout.TotalMinutes; //Lấy thời gian timeout | 2p

        // if (pendingTimeoutMinutes <= 0)
        // {
        //     pendingTimeoutMinutes = (int)DefaultPendingTimeout.TotalMinutes;
        // }

        var now = DateTimeOffset.UtcNow; //Lấy thời gian hiện tại | 10h10
        var threshold = now.AddMinutes(-pendingTimeoutMinutes);//threshold: mốc thời gian quá hạn | 10h08
        //lấy thời gian hiện tại trừ đi cho thời gian timeout

        var expiredPendingOrders = await _dbContext.Orders
            .Where(o => o.Status == PendingStatus && o.CreatedAt <= threshold)
            .ToListAsync(context.CancellationToken);
        //lấy những đơn hàng nào có trạng thái là pending và có giờ tạo mà tạo trước threshold
        
        //nếu không có đơn hàng nào hết hạn thì nghỉ
        if (expiredPendingOrders.Count == 0)
        {
            _logger.LogInformation("ProcessTransactionPendingJob completed: no expired pending orders found.");
            return;
        }
        //duyêt các đơn hàng hết hạng đó
            //chưa status về cancell
            //update thời gian sửa
        foreach (var order in expiredPendingOrders)
        {
            order.Status = CancelledStatus;
            order.UpdatedAt = now;
        }
        //update và lưu thay đổi
        _dbContext.Orders.UpdateRange(expiredPendingOrders);
        await _dbContext.SaveChangesAsync(context.CancellationToken);
        //log ra được là
        //đã huỷ X đơn hàng pending quá Y phút
        _logger.LogInformation(
            "ProcessTransactionPendingJob completed: cancelled {CancelledCount} pending orders older than {PendingTimeoutMinutes} minutes.",
            expiredPendingOrders.Count,
            pendingTimeoutMinutes);
    }
}