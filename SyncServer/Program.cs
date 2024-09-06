using Dotmim.Sync;
using Dotmim.Sync.SqlServer;
using Dotmim.Sync.Web.Server;

var builder = WebApplication.CreateBuilder(args);

// Thêm các dịch vụ vào container
builder.Services.AddControllers();

// Cấu hình kết nối đến SQL Server
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
var sqlSyncProvider = new SqlSyncChangeTrackingProvider(connectionString);

// Đăng ký dịch vụ đồng bộ
builder.Services.AddSyncServer(sqlSyncProvider, new string[] { "Products", "Customers" });

// Tạo ứng dụng
var app = builder.Build();

// Cấu hình HTTP request pipeline       
app.MapControllers();

app.Run();

