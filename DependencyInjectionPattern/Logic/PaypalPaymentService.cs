using DependencyInjectionPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPattern.Logic;

public class PaypalPaymentService : IPaymentService
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine($"Paiement de {amount} € effectué via PayPal.");
    }
}
