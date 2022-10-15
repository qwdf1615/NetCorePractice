using Microsoft.EntityFrameworkCore;
using Net6MVC.Models.Entity;

namespace Net6MVC.Data
{
    public class TestDBContext : DbContext
    {
        /*
         Code First 流程 (SQLite)
	    > 建立 Table Model (Models/Entity) _ 建立資料表與欄位
	    > 建立 DBContext (Data/DBContext.cs) 
	    > AddDbContext擴充方法 (Program.cs)
	    > 輸入指令 dotnet ef migrations add InitialCreate -o Data/Migratioins --project ProjectName
	    > 上述完成後, 輸入 dotnet ef database update --project ProjectName (建立或更新DB)
         */

        public TestDBContext() { }

        public TestDBContext(DbContextOptions<TestDBContext> options) : base(options)
        {

        }

        public DbSet<TblCompany> TblCompanyies { get; set; }
        public DbSet<TblItem> TblItems { get; set; }
        public DbSet<TblPurchase> TblPurchases { get; set; }
    }
}
