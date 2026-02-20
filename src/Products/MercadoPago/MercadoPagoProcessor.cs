using Project.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Products.MercadoPago
{
    public class MercadoPagoProcessor : IProcessor
    {
        public Task<string> ProcessTransactionAsync(decimal amount, string cardNumber)
        {
            Console.WriteLine($"MercadoPago: Processando R$ {amount}...");
            var transactionId = $"MP-{Guid.NewGuid().ToString().Substring(0, 8)}";
            return Task.FromResult(transactionId);
        }
    }
}
