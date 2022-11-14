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
    public class ItemTests
    {      
        private IValidatorForItems _valForItems;
        
        [TestInitialize]
        public void Setup()
        {          
            _valForItems = new ItemValidator();
        }

        [TestMethod]
        public void ItemValidation_MustBeTrueIfListIsNotEmpty()
        {
            var testList = new List<Product>()
            {
                new Product(""),
                new Product(""),
                new Product("")
            };
            
            var actual = _valForItems.IsValid(testList);
           
            actual.Should().BeTrue();
        }

        [TestMethod]
        public void ItemValidation_MustBeFalseIfListIsNotEmpty()
        {
            var testList = new List<Product>();

            var actual = _valForItems.IsValid(testList);

            actual.Should().BeFalse();
        }

        [TestMethod]
        public void ItemValidation_IdMustBeGreaterThanZero()
        {
            var item = new Product(0);
            
            var shouldBeFalse = _valForItems.IdIsValid(item.Id);
            shouldBeFalse.Should().BeFalse();         
        }        
    }
}
