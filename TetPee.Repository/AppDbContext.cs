using Microsoft.EntityFrameworkCore;
using TetPee.Repository.Entity;

namespace TetPee.Repository;

public class AppDbContext : DbContext//là một thằng đại diện cho db
    //kế thừa từ DbContext của EF Core
    //AppContext = cầu nối giữa C# code với DB
    //EF core ko làm việc trực tiếp với DB mà thông qua DbContext
    //A Tân: class đại diện cho Db và có method thần thánh OnModelCreating, sử dụng cho table
    /*
     _dbContext.Users.Add(user);
    _dbContext.SaveChanges();
    Thì thực chất:
    EF Core nhìn vào AppDbContext
    Biết:
    Có bảng Users
    Mapping với entity User
    Rồi tự sinh SQL để chạy vào DB
     */

{   //mấy cái này có nghĩa là gì vậy ?? hihi
    //tạo các ID cố định(static: chỉ tạo 1 lần duy nhất và dùng chung cho nhiều entity -> FK luôn đúng tuyệt đối),
    //  dùng cho seed data, special liên kết FK
    //  nếu không giữ lại ID đó, FK sẽ ko khớp
    // tại sao lại đặt ở đây, mà ko đặt ở trong OnModelCreating
        //vì OnModelCreating được gọi khi tạo migration or update DB -> ID thay đổi -> seed data bị vỡ FK
        
    public static Guid UserId1 = Guid.NewGuid(); //Seller
    public static Guid UserId2 = Guid.NewGuid(); //User
    
    public static Guid SellerId1 = Guid.NewGuid();
    
    public static Guid CateGoryParentId1 = Guid.NewGuid();
    public static Guid CateGoryParentId2 = Guid.NewGuid();
    
    public static Guid ProductId1 = Guid.NewGuid(); //sau này mình sẽ tạo data trong đơn hàng, tôi phải biết những sản phẩm đã tồn tại
    public static Guid ProductId2 = Guid.NewGuid();
    public static Guid ProductId3 = Guid.NewGuid();
    public static Guid ProductId4 = Guid.NewGuid();
    
    public static Guid OrderId1 = Guid.NewGuid();
    public static Guid OrderId2 = Guid.NewGuid();
   
    // public static Guid StorageId1 = Guid.NewGuid();
    
    
    //constructor của AppDbContext
    //  nhận cấu hình từ bên ngoài và truyền cho DbContext để
    //  EF Core biết cách kết nối  database
    public AppDbContext(DbContextOptions<AppDbContext> options) 
        : base(options) { }
    
    //Db<T>: khai báo bảng trong db thông qua AppDbContext
    public DbSet<User> Users  { get; set; }
    public DbSet<Seller> Sellers  { get; set; }
    public DbSet<Product> Products  { get; set; }
    public DbSet<ProductStorage> ProductStorages  { get; set; }
    public DbSet<Storage> Storages  { get; set; }
    public DbSet<Cart> Carts  { get; set; }
    public DbSet<Inventory> Inventories  { get; set; }
    public DbSet<Order> Orders  { get; set; }
    public DbSet<OrderDetail> OrderDetails  { get; set; }
    public DbSet<ProductCategory> ProductCategories  { get; set; }
    public DbSet<Category> Categories  { get; set; }

    
    //Nếu Entity là bản thiết kế cho db
    //thì OnModelCreating là "luật xây dựng cho db": là nơi cấu hình mô hình dữ liệu (Data Model)
    //Entity chỉ mô tả dữ liệu có thể có, còn OnModelCreating là nơi bắt database phải tuân theo các quy tắc đó,
    //bao gồm ràng buộc, quan hệ và dữ liệu khởi tạo
   protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // ==================== User Configuration ====================
        //nói với EF Core tôi đang cấu hình bảng User
        //tạo schema, set FK, hasdata, seed data
        modelBuilder.Entity<User>(builder =>
        {
            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(255);
            
            builder.HasIndex(u => u.Email)
                .IsUnique();
            
            builder.Property(u => u.FirstName)
                .IsRequired()
                .HasMaxLength(100);
            
            // LastName - required, max 100 characters
            builder.Property(u => u.LastName)
                .IsRequired()
                .HasMaxLength(100);
            
            // ImageUrl - nullable, max 500 characters (URL)
            builder.Property(u => u.ImageUrl)
                .HasMaxLength(500);
            
            // PhoneNumber - nullable, max 20 characters
            builder.Property(u => u.PhoneNumber)
                .HasMaxLength(20);
            
            // HashedPassword - required, max 500 characters
            builder.Property(u => u.HashedPassword)
                .IsRequired()
                .HasMaxLength(500);
            
            builder.Property(u => u.Role)
                .IsRequired()
                .HasMaxLength(20)
                .HasDefaultValue("User");
            
            // Relationship: User has one Seller (one-to-one)
            builder.HasOne(u => u.Seller)
                .WithOne(s => s.User)
                .HasForeignKey<Seller>(s => s.UserId) //FK nằm ở Seller
                .OnDelete(DeleteBehavior.Cascade); // Xóa User -> Seller xóa theo
            
            // DeleteBehavior.Cascade: Khi một User bị xóa, thì Seller liên quan cũng sẽ bị xóa theo.
            // DeleteBehavior.Restrict: Ngăn chặn việc xóa một User nếu có Seller liên quan tồn tại.
                //(Tham chiếu tới PK tồn tại)
                // 1 Project còn Task thì không xoá được
            // DeleteBehavior.NoAction: Không thực hiện hành động gì đặc biệt khi User bị xóa. ( Gàn giống Restrict, xử lí ở DB)
            // DeleteBehavior.SetNull: Khi một User bị xóa, thì trường UserId trong bảng Seller sẽ được đặt thành NULL.
                //(Áp dụng khi trường FK cho phép NULL)
    
            //seed data: giữ liệu được gieo sẵn vào db ngay từ đầu, dùng để test, demo    
            //user gốc: mục đích FK, nghiệp vụ
            List<User> users = new List<User>()
            {
                new ()
                {
                    Id = UserId1,
                    Email = "tan182205@gmail.com",
                    FirstName = "Tan",
                    LastName = "Tran",
                    HashedPassword = "hashed_password_1",
                },
                new ()
                {
                    Id = UserId2,
                    Email = "tan182206@gmail.com",
                    FirstName = "Tan",
                    LastName = "Tran",
                    HashedPassword = "hashed_password_1",
                }
            };
            //seed data
            for (int i = 0; i <= 1000; i++)
            {
                var newUser = new User()
                {
                    Id = Guid.NewGuid(),
                    Email = "Tan" + i + "@gmail.com",
                    FirstName = "Tan" + i,
                    LastName = "Tran" + i,
                    HashedPassword = "hashed_password_" + i,
                };
                users.Add(newUser);
            }
            
            builder.HasData(users);
            //dữ liệu được insert vào db
        });

        modelBuilder.Entity<Seller>(builder =>
        {
            builder.Property(s => s.TaxCode)
                .IsRequired()
                .HasMaxLength(50);
            
            builder.Property(s => s.CompanyName)
                .IsRequired()
                .HasMaxLength(200);
            
            builder.Property(s => s.CompanyAddress)
                .IsRequired()
                .HasMaxLength(500);

            var seller = new List<Seller>()
            {
                new ()
                {
                    Id = SellerId1,
                    TaxCode = "TAXCODE123",
                    CompanyName = "ABC Company",
                    CompanyAddress = "123 Main St, Cityville",
                    UserId = UserId1, // tạo seller thì phải có user trước, vì seller là user
                    //kiếm một thằng id đã tồn tại trong user
                }
            };
            
            builder.HasData(seller);
        });

        modelBuilder.Entity<Category>(builder =>
        { 
            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100);
            
            var categories = new List<Category>()
            {
                new ()
                {
                    Id = CateGoryParentId1,
                    Name = "Áo",
                },
                new ()
                {
                    Id = CateGoryParentId2,
                    Name = "Quần",
                },
                new ()
                {
                    Id = Guid.NewGuid(),
                    Name = "Áo thể thao",
                    ParentId = CateGoryParentId1 //cha của nó đã xác định rồi thì con mới tồn tại
                },
                new ()
                {
                    Id = Guid.NewGuid(),
                    Name = "Áo ba lỗ",
                    ParentId = CateGoryParentId1
                },
                new ()
                {
                    Id = Guid.NewGuid(),
                    Name = "Quần Jean",
                    ParentId = CateGoryParentId2
                },
            };

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 0)
                {
                    var newCategory = new Category()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Áo " + i,
                        ParentId = CateGoryParentId1
                                   
                    };
                    categories.Add(newCategory);
                }
                else
                {
                    var newCategory = new Category()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Quần " + i,
                        ParentId = CateGoryParentId2
                                   
                    };
                    categories.Add(newCategory);
                }
            }
            builder.HasData(categories);
        });

        modelBuilder.Entity<Product>(builder =>
        {
            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);
            
            builder.Property(p => p.Description)
                .IsRequired()
                .HasMaxLength(500);
            
            builder.Property(p => p.UrlImage)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(p => p.Price)
                .IsRequired();
            
            // builder.HasOne(p => p.Seller)//Product có 1 user
            //     .WithMany(s => s.Products)//seller có nhiều product -> =Iclolection<Product>
            //     .HasForeignKey(s => s.SellerId)
            //     .OnDelete(DeleteBehavior.Cascade);
            
            var products = new List<Product>()
            {
                new Product()
                {
                    Id = ProductId1,
                    Name = "Áo Thun Nam",
                    Description = "Áo thun nam chất liệu cotton cao cấp, thoáng mát, phù hợp cho mọi hoạt động hàng ngày.",
                    UrlImage = "https://example.com/images/ao_thun_nam.jpg",
                    Price = 199000m,
                    SellerId = SellerId1
                },
                new Product()
                {
                    Id = ProductId2,
                    Name = "Quần Jeans Nữ",
                    Description = "Quần jeans nữ dáng ôm, tôn dáng, chất liệu denim co giãn, phù hợp cho mọi dịp.",
                    UrlImage = "https://example.com/images/quan_jeans_nu.jpg",
                    Price = 399000m,
                    SellerId = SellerId1
                },
                new Product()
                {
                    Id = ProductId3,
                    Name = "Áo Sơ Mi Nam",
                    Description = "Áo sơ mi nam công sở, thiết kế hiện đại, chất liệu vải cao cấp, thoáng mát.",
                    UrlImage = "https://example.com/images/ao_so_mi_nam.jpg",
                    Price = 299000m,
                    SellerId = SellerId1
                },
                new Product()
                {
                    Id = ProductId4,
                    Name = "Chân Váy Nữ",
                    Description = "Chân váy nữ xòe, thiết kế trẻ trung, chất liệu vải mềm mại, phù hợp cho mọi dịp.",
                    UrlImage = "https://example.com/images/chan_vay_nu.jpg",
                    Price = 249000m,
                    SellerId = SellerId1
                }
            };
            // for (int i = 0; i <= 1000; i++)
            // {
            //     var newProduct = new Product()
            //     {
            //         Id = Guid.NewGuid(),
            //         Name = "T-Shirt" + i,
            //         Description = "Basic T-Shirt" + i,
            //         Price = 199000,
            //         SellerId = SellerId1
            //     };
            //     
            //     products.Add(newProduct);
            // }
            
            builder.HasData(products);

        });

        modelBuilder.Entity<Order>(builder =>
        {
            var orders = new List<Order>()
            {
                new Order()
                {
                    Id = OrderId1,
                    UserId = UserId2,
                    Address = "Bien hoa, Dong Nai",
                    TotalAmount = 10000,
                    Status = "Completed"
                },
                new Order()
                {
                    Id = OrderId2,
                    UserId = UserId2,
                    Address = "Bien hoa, Dong Nai",
                    TotalAmount = 10000,
                    Status = "Completed"
                },
            };
            builder.HasData(orders);
            
        });

        modelBuilder.Entity<OrderDetail>(builder =>
        {
            var orderDetails = new List<OrderDetail>()
            {
                new OrderDetail()
                {
                    Id = Guid.NewGuid(),
                    OrderId = OrderId1,
                    ProductId = ProductId1,
                    Quantity = 2,
                    UnitPrice = 19990000
                },
                new OrderDetail()
                {
                    Id = Guid.NewGuid(),
                    OrderId = OrderId1,
                    ProductId = ProductId2,
                    Quantity = 1,
                    UnitPrice = 39990000
                },
                new OrderDetail()
                {
                    Id = Guid.NewGuid(),
                    OrderId = OrderId2,
                    ProductId = ProductId3,
                    Quantity = 1,
                    UnitPrice = 29990000
                },
            };
            
            builder.HasData(orderDetails);
        });
    
        

        /* modelBuilder.Entity<Storage>(builder =>
         {
             builder.Property(s => s.Price)
                 .IsRequired();

             builder.Property(s => s.Type)
                 .IsRequired()
                 .HasMaxLength(50);
             var storages = new List<Storage>()
             {
                 new()
                 {
                     Id = StorageId1,
                     Price = 23434234,
                     Type = "hihi",
                 }
             };

             for (int i = 0; i <= 1000; i++)
             {
                 var storage = new Storage()
                 {
                     Id = Guid.NewGuid(),
                     Price = 23434234 + i,
                     Type = "hihi" + i,
                 };
                 storages.Add(storage);
             }

             builder.HasData(storages);
         });*/

    }
}
