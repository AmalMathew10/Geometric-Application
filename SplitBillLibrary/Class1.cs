using System;
using System.Collections.Generic;

namespace SplitBillLibrary
{
    public class BillSplitter
    {
        public decimal SplitAmount(decimal totalAmount, int numberOfPeople)
        {
            if (numberOfPeople <= 0)
                throw new ArgumentException("Number of people must be greater than zero.");

            return totalAmount / numberOfPeople;
        }

        public Dictionary<string, decimal> CalculateTip(Dictionary<string, decimal> mealCosts, float tipPercentage)
        {
            if (mealCosts == null)
                throw new ArgumentNullException(nameof(mealCosts), "Meal costs dictionary cannot be null.");

            if (tipPercentage < 0 || tipPercentage > 100)
                throw new ArgumentException("Tip percentage must be between 0 and 100.", nameof(tipPercentage));

            decimal totalCost = 0;
            foreach (var cost in mealCosts.Values)
            {
                totalCost += cost;
            }

            var tipPerPerson = new Dictionary<string, decimal>();
            foreach (var kvp in mealCosts)
            {
                decimal tipAmount = kvp.Value * (decimal)(tipPercentage / 100.0);
                tipPerPerson[kvp.Key] = tipAmount;
            }

            return tipPerPerson;
        }

        public decimal CalculateTipPerPerson(decimal price, int numberOfPatrons, float tipPercentage)
        {
            if (numberOfPatrons <= 0)
                throw new ArgumentException("Number of patrons must be greater than zero.");

            if (tipPercentage < 0 || tipPercentage > 100)
                throw new ArgumentException("Tip percentage must be between 0 and 100.", nameof(tipPercentage));

            decimal tipAmount = price * (decimal)(tipPercentage / 100.0);
            return tipAmount / numberOfPatrons;
        }
    }
}
