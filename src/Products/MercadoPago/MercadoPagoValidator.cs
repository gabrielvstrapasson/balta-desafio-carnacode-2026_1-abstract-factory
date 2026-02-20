using Project.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Products.MercadoPago
{
    public class MercadoPagoValidator : IValidator
    {
        public Task<bool> ValidateCard(string cardNumber)
        {
            Console.WriteLine("MercadoPago: Validando cartão...");
            return Task.FromResult(cardNumber.Length == 16 && cardNumber.StartsWith("5"));
        }
    }
}
