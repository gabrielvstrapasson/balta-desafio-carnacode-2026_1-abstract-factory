using Project.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Products.Stripe
{
    public class StripeProcessor : IProcessor
    {
        public Task<string> ProcessTransactionAsync(decimal amount, string cardNumber)
        {
            Console.WriteLine($"Stripe: Processando ${amount}...");
            var transactionId = $"STRIPE-{Guid.NewGuid().ToString().Substring(0, 8)}";
            return Task.FromResult(transactionId);
        }
    }
}
