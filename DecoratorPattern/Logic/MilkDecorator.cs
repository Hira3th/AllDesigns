using DecoratorPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Logic;

public class MilkDecorator : IBeverage
{
    private IBeverage _beverage;

    public MilkDecorator(IBeverage beverage)
    {
        _beverage = beverage;
    }

    public string GetDescription() => _beverage.GetDescription() + ", avec Lait";
    public double GetCost() => _beverage.GetCost() + 1.0;
}
