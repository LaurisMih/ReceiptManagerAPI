using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReceiptManager.Data;
using ReceiptManager.Main.Interfaces;
using ReceiptManager.Main.Models;
using ReceiptManager.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ScooterRentalAPI.Controllers
{
    [Route("receiptController")]
    [ApiController]
    public class ReceiptController : ControllerBase
    {
       
        private readonly IReceiptService _receiptService;
        private readonly IReceiptDbContext _context;
        public ReceiptController(IReceiptService receiptService, IReceiptDbContext context )
        {
            _receiptService = receiptService;
            _context = context;
        }
        
        [Route("/addReceipt")]
        [HttpPost]
        public IActionResult AddReceipt(List<Product> products)
        {
            //var product = _context.Products.Include().ToList();
            var time = DateTime.UtcNow;
            var result = _receiptService.AddReceipt( products);            
             if (result.Success)
             {
                 return Created("", result.Entity);
             }
             return BadRequest(result);            
        }

        [Route("GetReceiptById")]
        [HttpGet]
        public IActionResult GetReceiptById(int id)
        {

            var receiptId = _receiptService.GetReceiptById(id);

            if (receiptId == null)
            {
                return NotFound();
            }

            return Ok(receiptId);
        }

        [Route("GetReceiptsByTime")]
        [HttpGet]
        public IActionResult GetReceiptsByTime(DateTime timeStart, DateTime timeEnd)
        {
            var receipts = _receiptService.GetReceiptsByTime(timeStart, timeEnd);
            return Created("", receipts);
        }

        [Route("GetAllReceipts")]
        [HttpGet]
        public IActionResult GetAllReceipts()
        {
            var receipts = _receiptService.GetAllReceipts();
            return Created("", receipts);
        }

        [Route("FilterReceipt")]
        [HttpGet]
        public IActionResult FilterReceiptByItemsName(string itemName)
        {

            var name = _receiptService.FilterReceiptsByItem(itemName);

            if (name == null)
            {
                return NotFound();
            }

            return Ok(name);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteReceiptById(int id)
        {
            ReceiptManager.Main.Models.Receipt receipt = _receiptService.GetById(id);
            if (receipt != null)
            {
                var result = _receiptService.Delete(receipt);
                if (result.Success)
                {
                    return Ok();
                }
                return Problem(result.FormatedErrors);
            }
            return Problem();
        }
    }
}
