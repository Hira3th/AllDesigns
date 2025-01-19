using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPattern.Models
{
    internal interface IPaymentService
    {
        void ProcessPayment(double amount);
    }
}
