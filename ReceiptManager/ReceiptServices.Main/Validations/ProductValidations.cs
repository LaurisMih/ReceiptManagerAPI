using ReceiptManager.Main.Interfaces;
using ReceiptManager.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReceiptManager.Main.Validations
{
    public class ProductValidations : IProductValidator
    {
        Regex regexItem = new Regex("^[a-zA-Z0-9 ]*$");
        public bool IsValid(Product product)
        {
            if (regexItem.IsMatch(product.Name))
            {
                return true;
            }
            return false;
        }
    }
}
