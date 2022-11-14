using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReceiptManager.Data;
using ReceiptManager.Main.Interfaces;
using ReceiptManager.Main.Models;
using ReceiptManager.Main.Validations;
using ReceiptManager.Services;
using System;
using System.Collections.Generic;

namespace ReceiptManager.Tests
{
    [TestClass]
    public class ProductTests  
    {
      
        private IProductValidator _nameValidator;
             
        [TestInitialize]
        public void Setup()
        {           
            _nameValidator = new ProductValidations();                  
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

