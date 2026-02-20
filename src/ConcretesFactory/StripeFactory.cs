using Project.Interfaces;
using Project.Products.Stripe;

namespace Project.ConcretesFactory
{
    public class StripeFactory : IPaymentGatewayFactory
    {
        public ILogger CreateLogger() => new StripeLogger();

        public IProcessor CreateProcessor() => new StripeProcessor();

        public IValidator CreateValidator() => new StripeValidator();

    }
}
