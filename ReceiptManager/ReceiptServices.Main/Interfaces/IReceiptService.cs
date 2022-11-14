using ReceiptManager.Main.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReceiptManager.Services.Interfaces;

namespace ReceiptManager.Main.Interfaces
{
    public interface IReceiptService : IEntityService<Receipt>
    {

        ServiceResults AddReceipt(/*DateTime dateTime,*/ List<Product> products);
        //List<Receipt> AddReceipt(DateTime dateTime, List<Product> products);
        ServiceResults RemoveReceipt(int id);

        List<Receipt> GetAllReceipts();
        Receipt GetReceiptById(int scooterId);
        IEnumerable<Receipt> GetReceiptsByTime(DateTime timeStart, DateTime timeEnd);

        List<Receipt> FilterReceiptsByItem(string itemProductName);
    }

}
