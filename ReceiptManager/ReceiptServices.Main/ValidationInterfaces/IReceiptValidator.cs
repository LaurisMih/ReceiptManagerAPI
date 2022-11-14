using ReceiptManager.Main.Models;

namespace ReceiptServices.Main.ValidationInterfaces
{
    public interface IReceiptValidator
    {
        bool IsValid(Receipt receipt);
    }
}