using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReceiptManager.Data;
using ReceiptManager.Main.Interfaces;
using ReceiptManager.Main.Models;
using ReceiptManager.Main.Validations;
using ReceiptManager.Services;
using ReceiptManager.Services.Interfaces;
using ScooterRentalAPI.Controllers;
using System;
using System.Collections.Generic;

namespace ReceiptManager.Tests
{
    [TestClass]
    public class ReceiptTests
    {
        private Receipt _receipt;
        private ReceiptDbContext receiptDbContext;
        private IReceiptService _receiptService;
        private IDbService _dbService;
        private DbContext _dbContext;
        public ReceiptController _receiptController;
        private IReceiptValidator _receiptValidator;
        private IReceiptValidator _timeValidator;

        [TestInitialize]
        public void Setup()
        {
            _receiptValidator = new ReceiptValidations();
            _timeValidator = new ReceiptTimeValidations();
            receiptDbContext = new ReceiptDbContext();
            _receiptService = new ReceiptService(receiptDbContext);
        }
        
        [TestMethod]
        public void ReceiptCreation_IdAndTimeSetCorrectly()
        {
            _receipt = new Receipt(1, DateTime.UtcNow);
            _receipt.Id.Should().Be(1);
            _receipt.CreatedOn.Should().BeCloseTo(DateTime.UtcNow, TimeSpan.FromMilliseconds(100));
            
        }

        [TestMethod]
        public void ReceiptValidations_ShouldReturnFalseIfGivenZeroOrNegativeId()
        {
            var receiptIdTrue = new Receipt(1, DateTime.UtcNow);
            var receiptIdFalse = new Receipt(0, DateTime.UtcNow);

            _receiptValidator.IsValid(receiptIdTrue).Should().BeTrue();
            _receiptValidator.IsValid(receiptIdFalse).Should().BeFalse();
            
        }

        [TestMethod]
        public void TimeValidations_ShouldReturnFalseIfTimeIsNotUtcNow()
        {           
            var receiptTimeFalse = new Receipt(2, DateTime.Now);  
            
            _timeValidator.IsValid(receiptTimeFalse).Should().BeFalse();
        }       
    }
}
