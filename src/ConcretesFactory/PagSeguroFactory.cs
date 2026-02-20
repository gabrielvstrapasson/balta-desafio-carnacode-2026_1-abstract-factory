using Project.Interfaces;
using Project.Products.PagSeguro;
using System;

namespace Project.ConcretesFactory
{
    public class PagSeguroFactory : IPaymentGatewayFactory
    {
        public IProcessor CreateProcessor() => new PagSeguroProcessor();

        public ILogger CreateLogger() => new PagSeguroLogger();

        public IValidator CreateValidator() => new PagSeguroValidator();

    }
}
