using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReceiptManager.Services.Interfaces;
using ReceiptManager.Main.Models;
using ReceiptManager.Data;
using ReceiptManager.Main.Interfaces;
using ReceiptManager.Services.Services;
using Microsoft.EntityFrameworkCore;

namespace ReceiptManager.Services
{
    public class ReceiptService : EntityService<Receipt>,IReceiptService
    {
        private readonly IDbService _dbService;
        private readonly IReceiptDbContext _context;

       
        public ReceiptService(IDbService dbService, IReceiptDbContext receiptDbContext, ReceiptDbContext context) : base(context)
        {
            _dbService = dbService;
            _context = receiptDbContext;
        }

        public ReceiptService(ReceiptDbContext context) : base(context)
        {
        }

        public ServiceResults AddReceipt(List<Product> products)      
        {                     
             return Create(new Receipt(products));
        }
        
        public ServiceResults RemoveReceipt(int id)
        {
           
           var scooterId = GetById(id);
           return Delete(scooterId);                        
        }

        public List<Receipt> GetAllReceipts()
        {
            return _context.Receipts.Include(r => r.Items).ToList();
            
        }

        public Receipt GetReceiptById(int receiptId)
        {
            
            return Query<Receipt>().Include(receipt => receipt.Items)
                .FirstOrDefault(receipt => receipt.Id == receiptId);
        }

        public IEnumerable<Receipt> GetReceiptsByTime(DateTime lowerRange, DateTime upperRange)
        {

          
            return Query<Receipt>().Include(receipt => receipt.Items)
                .Where(receipt => receipt.CreatedOn >= lowerRange && receipt.CreatedOn <= upperRange).ToList();

        }

        public List<Receipt> FilterReceiptsByItem(string itemProductName)
        {
            return Query<Receipt>().Include(receipt => receipt.Items)
                .Where(receipt => receipt.Items.Any(item => item.Name == itemProductName)).ToList();
        }
    }
}
