// See https://aka.ms/new-console-template for more information
using System.Text;
using DependencyInjectionPattern.Logic;
using DependencyInjectionPattern.Models;

Console.WriteLine("Hello, Dependency Injection!");

PaypalPaymentService paymentService = new PaypalPaymentService();
Order order = new Order(paymentService);

Console.OutputEncoding = Encoding.UTF8;

// Simulate a payment of 50 euros
order.CompleteOrder(50);

Console.ReadLine();