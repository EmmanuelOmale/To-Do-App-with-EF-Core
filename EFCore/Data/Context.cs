using Microsoft.EntityFrameworkCore;
using EFCore.Models;

namespace EFCore.Data
{
    public class Context : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
           
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-CMML9AE\\SQLEXPRESS;Initial Catalog=EFCore;Integrated Security=True;TrustServerCertificate=True;");
        }
    }
}
