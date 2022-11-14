
using System;
using System.Collections.Generic;

namespace ReceiptManager.Main.Models
{
    public class Receipt : Entity
    {        
        public Receipt()
        {

        }
       /* public Receipt(DateTime utcNow)
        {
            CreatedOn = utcNow;
        }
        public Receipt(DateTime utcNow, List<Product> items)
        {
            
            CreatedOn = utcNow;
        }*/

        public Receipt(int id, DateTime utcNow)
        {
            Id = id;
            CreatedOn = utcNow;
        }

        public Receipt( int id, DateTime createdOn, List<Product> items)
        {
            Id = id;
            CreatedOn = createdOn;
            Items = items;
        }

        public Receipt(List<Product> items, DateTime? time = null)
        {
            CreatedOn = time ?? DateTime.Now;
            Items = items;
        }
        public DateTime CreatedOn { get; set; }
        public List<Product> Items { get; set; }
    }
}