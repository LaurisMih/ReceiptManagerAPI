using ReceiptManager.Main.Models;

namespace ReceiptManager.Main.Interfaces
{
    public interface IProductValidator
    {
        bool IsValid(Product product);
    }
}
