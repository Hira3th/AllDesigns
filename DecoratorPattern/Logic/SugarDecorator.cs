using DecoratorPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Logic;

public class SugarDecorator : IBeverage
{
    private IBeverage _beverage;

    public SugarDecorator(IBeverage beverage)
    {
        _beverage = beverage;
    }

    public string GetDescription() => _beverage.GetDescription() + ", avec Sucre";
    public double GetCost() => _beverage.GetCost() + 0.5;
}
