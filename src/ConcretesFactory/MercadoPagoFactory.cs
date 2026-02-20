using Project.Interfaces;
using Project.Products.MercadoPago;
using System;

namespace Project.ConcretesFactory
{
    public class MercadoPagoFactory : IPaymentGatewayFactory
    {
        public ILogger CreateLogger() => new MercadoPagoLogger();  

        public IProcessor CreateProcessor() => new MercadoPagoProcessor();


        public IValidator CreateValidator() => new MercadoPagoValidator();
    }
}
