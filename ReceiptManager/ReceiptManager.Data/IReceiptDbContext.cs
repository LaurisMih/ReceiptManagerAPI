using Microsoft.EntityFrameworkCore;
using ReceiptManager;
using ReceiptManager.Main.Models;
using System.Threading.Tasks;

namespace ReceiptManager.Data
{
    public interface IReceiptDbContext
    {
        DbSet<Receipt> Receipts { get; set; }
        DbSet<Product> Products { get; set; }       
        Task<int> SaveChangesAsync();
        int SaveChanges();
    }
}