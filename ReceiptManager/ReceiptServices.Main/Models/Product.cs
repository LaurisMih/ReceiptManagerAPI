using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptManager.Main.Models
{
    public class Product : Entity
    {
        public Product()
        {
           
        }

        public Product(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

    }
}
