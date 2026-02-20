using Project.Interfaces;
using System;
using System.Threading.Tasks;

namespace Project.Products.PagSeguro
{
    public sealed class PagSeguroProcessor : IProcessor
    {
        public Task<string> ProcessTransactionAsync(decimal amount, string cardNumber)
        {
            Console.WriteLine($"PagSeguro: Processando R$ {amount}...");
            var transactionId = $"PAGSEG-{Guid.NewGuid().ToString().Substring(0, 8)}";
            return Task.FromResult(transactionId);
        }
    }
}
