using Microsoft.EntityFrameworkCore;
using ReceiptManager.Main.Models;
using System.Threading.Tasks;

namespace ReceiptManager.Data
{
    public class ReceiptDbContext : DbContext, IReceiptDbContext
    {
        public ReceiptDbContext()
        {
        }

        public ReceiptDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<Product> Products { get; set; }

       

        public Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }
    }
}
