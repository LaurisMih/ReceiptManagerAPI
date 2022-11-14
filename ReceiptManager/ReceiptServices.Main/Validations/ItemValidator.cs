using ReceiptManager.Main.Models;
using ReceiptServices.Main.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
