using ReceiptManager.Main.Models;
using ReceiptServices.Main.ValidationInterfaces;
using System;

namespace ReceiptManager.Main.Validations
{
    public class ReceiptTimeValidations : IReceiptValidator
    {
        public bool IsValid(Receipt receipt)
        {
            if (receipt.CreatedOn != DateTime.UtcNow)
            {
                return false;
            }
            return true;
        }
    }
}
