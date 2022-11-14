using ReceiptManager.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptManager.Main.Interfaces
{
    public interface IProductValidator
    {
        bool IsValid(Product product);
    }
}
