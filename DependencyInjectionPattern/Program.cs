// See https://aka.ms/new-console-template for more information
using DependencyInjectionPattern.Logic;
using DependencyInjectionPattern.Models;

Console.WriteLine("Hello, Dependency Injection!");

PaypalPaymentService paymentService = new PaypalPaymentService();
Order order = new Order((IPaymentService)paymentService);

order.CompleteOrder(50);