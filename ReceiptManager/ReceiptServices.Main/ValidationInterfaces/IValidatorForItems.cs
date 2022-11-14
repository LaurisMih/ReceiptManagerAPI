using ReceiptManager.Main.Models;
using System.Collections.Generic;

namespace ReceiptServices.Main.ValidationInterfaces
{
    public interface IValidatorForItems
    {
        bool IsValid(List<Product> item);
        bool IdIsValid(int id);
    }
}