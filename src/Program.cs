using Project.Client;
using Project.ConcretesFactory;
using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Sistema de Pagamentos ===\n");

        var pagSeguroFactory = new PagSeguroFactory();
        var pagSeguroService = new PaymentService(pagSeguroFactory);
        _ = pagSeguroService.CheckoutAsync(150.00m, "1234567890123456");

        Console.WriteLine();

        var mercadoPagoFactory = new MercadoPagoFactory();
        var mercadoPagoService = new PaymentService(mercadoPagoFactory);
        _ = mercadoPagoService.CheckoutAsync(200.00m, "5234567890123456");

        Console.WriteLine();

    }
}