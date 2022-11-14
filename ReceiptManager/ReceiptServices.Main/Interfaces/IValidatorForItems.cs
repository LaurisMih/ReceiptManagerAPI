using ReceiptManager.Main.Models;
using System.Collections.Generic;

namespace ReceiptServices.Main.Interfaces
{
    public interface IValidatorForItems
    {
        bool IsValid(List<Product> item);
        bool IdIsValid(int id);
        
    }
}