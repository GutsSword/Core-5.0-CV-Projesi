using CoreP1_Api.DAL.ApiEntity;
using Microsoft.EntityFrameworkCore;

namespace CoreP1_Api.DAL.ApiContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-SF0I6NA\\SQLEXPRESS;database=CoreP1-2;integrated security=true");
        }
        public DbSet<Category> Categories { get; set; }
    }
}
