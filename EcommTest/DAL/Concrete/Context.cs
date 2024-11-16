using EcommTest.DAL.Entites;
using Microsoft.EntityFrameworkCore;

namespace EcommTest.DAL.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-TOGRPIE\\SQLEXPRESS; initial catalog=eCommTestDb; integrated security=true");
        }
        public DbSet<ProductDetail> productDetails { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductAttrubute> ProductAttrubutes { get; set; }
    }
}
