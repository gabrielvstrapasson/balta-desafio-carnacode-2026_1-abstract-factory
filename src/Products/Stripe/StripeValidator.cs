using Project.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Products.Stripe
{
    public class StripeValidator : IValidator
    {
        public Task<bool> ValidateCard(string cardNumber)
        {
            Console.WriteLine("Stripe: Validando cartão...");
            return Task.FromResult(cardNumber.Length == 16 && cardNumber.StartsWith("4"));
        }
    }
}
