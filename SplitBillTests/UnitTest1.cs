using System;
using System.Collections.Generic;
using Xunit;
using SplitBillLibrary;

namespace SplitBillTests
{
    public class BillSplitterTests
    {
        [Theory]
        [InlineData(100, 5, 20)]
        [InlineData(75, 3, 25)]
        [InlineData(150, 10, 15)]
        public void SplitAmount_ReturnsCorrectAmount(decimal totalAmount, int numberOfPeople, decimal expectedAmount)
        {
            
            var billSplitter = new BillSplitter();

            
            decimal actualAmount = billSplitter.SplitAmount(totalAmount, numberOfPeople);

            
            Assert.Equal(expectedAmount, actualAmount);
        }

        [Fact]
        public void CalculateTip_ReturnsCorrectTipAmount()
        {
           
            var billSplitter = new BillSplitter();
            var mealCosts = new Dictionary<string, decimal>
            {
                {"John", 25.50m},
                {"Alice", 30.25m},
                {"Bob", 20.75m}
            };
            float tipPercentage = 15;

            var result = billSplitter.CalculateTip(mealCosts, tipPercentage);

            Assert.Equal(3.825m, result["John"]);
            Assert.Equal(4.5375m, result["Alice"]);
            Assert.Equal(3.1125m, result["Bob"]);
        }

        [Theory]
        [InlineData(100, 4, 10, 2.5)]
        [InlineData(80, 2, 20, 4)]
        [InlineData(120, 6, 15, 2)]
        public void CalculateTipPerPerson_ReturnsCorrectAmount(decimal price, int numberOfPatrons, float tipPercentage, decimal expectedAmount)
        {
            \
            var billSplitter = new BillSplitter();

            decimal actualAmount = billSplitter.CalculateTipPerPerson(price, numberOfPatrons, tipPercentage);

            Assert.Equal(expectedAmount, actualAmount);
        }
    }
}
