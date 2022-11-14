using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReceiptManager.Data;
using ReceiptManager.Main.Interfaces;
using ReceiptManager.Main.Models;
using ReceiptManager.Main.Validations;
using ReceiptManager.Services;
using ReceiptServices.Main.Interfaces;
using ReceiptServices.Main.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptManager.Tests
{
    [TestClass]
    public class ProductTests  
    {
        private IReceiptService _receiptService;
        private IProductValidator _nameValidator;
        private ReceiptDbContext _dbContext;
        private Receipt _receipt;
        private List<Product> _list;
       

        [TestInitialize]
        public void Setup()
        {
            _dbContext = new ReceiptDbContext();
            _receiptService = new ReceiptService(_dbContext);
            _nameValidator = new ProductValidations();
            _list = new List<Product>();
            _receipt = new Receipt(1, DateTime.UtcNow, _list);
           
        }

        [TestMethod]
        public void ProductCreation_NameMustNotContainSpecialChars()
        {
            var product = new Product("banana!");
            var product1 = new Product("banana");

            _nameValidator.IsValid(product).Should().BeFalse();
            _nameValidator.IsValid(product1).Should().BeTrue();

        }

        

    }
}

