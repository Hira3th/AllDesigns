using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Models;

public class Coffee : IBeverage
{
    public string GetDescription() => "Café";
    public double GetCost() => 2.0;
}
