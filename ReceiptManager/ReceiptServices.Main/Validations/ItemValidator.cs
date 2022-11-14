using ReceiptManager.Main.Models;
using ReceiptServices.Main.ValidationInterfaces;
using System.Collections.Generic;

namespace ReceiptServices.Main.Validations
{
    public class ItemValidator : IValidatorForItems
    {
        public bool IsValid(List<Product> item)
        {
            return item.Count > 0;
        }

        public bool IdIsValid(int id)
        {
            if (id > 0)
            {
                return true;
            }
            return false;
        }   
    }
}
