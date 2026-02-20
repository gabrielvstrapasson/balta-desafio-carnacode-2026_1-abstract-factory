using Project.Interfaces;
using System;
using System.Threading.Tasks;

namespace Project.Client
{
    public sealed class PaymentService(IPaymentGatewayFactory gatewayFactory)
    {
        private readonly ILogger _logger = gatewayFactory.CreateLogger();
        private readonly IProcessor _processor = gatewayFactory.CreateProcessor();
        private readonly IValidator _validator = gatewayFactory.CreateValidator();

        public async Task CheckoutAsync(decimal amount, string cardNumber)
        {
            if (!await _validator.ValidateCard(cardNumber))
            {
                Console.WriteLine("Invalid Card");
                return;
            }

            var result = await _processor.ProcessTransactionAsync(amount, cardNumber);
            _logger.Log($"Transaction processed: {result}");

        }
    }
}
