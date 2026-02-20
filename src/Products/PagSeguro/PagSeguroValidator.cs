using Project.Interfaces;
using System;
using System.Threading.Tasks;

namespace Project.Products.PagSeguro
{
    public class PagSeguroValidator : IValidator
    {
        public Task<bool> ValidateCard(string cardNumber)
        {
            Console.WriteLine("PagSeguro: Validando cartão...");
            return Task.FromResult(cardNumber.Length == 16);
        }
    }
}
