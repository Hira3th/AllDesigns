using DependencyInjectionPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPattern.Logic;

public class Order
{
    private IPaymentService _paymentService;

    public Order(IPaymentService paymentService)
    {
        _paymentService = paymentService;
    }

    public void CompleteOrder(double amount)
    {
        _paymentService.ProcessPayment(amount);
        Console.WriteLine("Commande finalisée !");
    }
}
