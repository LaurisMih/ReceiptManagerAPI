using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReceiptManager.Main.Interfaces;
using ReceiptManager.Main.Models;
using ReceiptManager.Main.Validations;
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
        private Product _product;
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

