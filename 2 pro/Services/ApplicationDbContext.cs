using _2_pro.Models;
using Microsoft.EntityFrameworkCore;

namespace _2_pro.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        {
            
        }
        public DbSet<Product> products { get; set; }
    }
}
