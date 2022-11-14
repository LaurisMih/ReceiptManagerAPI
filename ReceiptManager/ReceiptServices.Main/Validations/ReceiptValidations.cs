using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReceiptManager.Main.Interfaces;
using ReceiptManager.Main.Models;
using ReceiptManager.Services.Interfaces;
using ReceiptServices.Main.ValidationInterfaces;

namespace ReceiptManager.Main.Validations
{
    public class ReceiptValidations : IReceiptValidator
    {
        private readonly IDbService dbService;
        private readonly IReceiptService receiptService;
        
        public bool IsValid(Receipt receipt)
        {
            if (receipt.Id <= 0)
            {
                return false;
            }

            return true;           
        }    
    }
}
