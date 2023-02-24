using Microsoft.EntityFrameworkCore;
using Nevada.Models;

namespace Nevada.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ShoeOrder> ShoeOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
