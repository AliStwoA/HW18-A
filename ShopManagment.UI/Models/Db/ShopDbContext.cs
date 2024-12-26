using Microsoft.EntityFrameworkCore;
using ShopManagment.UI.Models.Entities;

namespace ShopManagment.UI.Models.Db
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source=(localdb)\\MSSQLLocalDB; Initial catalog=TehranShop");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Product> Products { get; set; }
       

    }
}
