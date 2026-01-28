namespace TetPee.Repository.Abstraction;

public interface IAuditableEntity
{
    public DateTimeOffset CreatedAt { get; set; } // Dòng dữ liệu này được tạo ra khí nào
    public DateTimeOffset? UpdatedAt { get; set; } // dòng dữ liệu này được cập nhật dòng cuối khi nào
}