using ReceiptManager.Main.Interfaces;
using ReceiptManager.Main.Models;
using System.Text.RegularExpressions;

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
