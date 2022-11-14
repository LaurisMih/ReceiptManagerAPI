using ReceiptManager.Main.Interfaces;
using ReceiptManager.Main.Models;
using ReceiptServices.Main.ValidationInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
