// See https://aka.ms/new-console-template for more information
using DecoratorPattern.Logic;
using DecoratorPattern.Models;

Console.WriteLine("Hello, Decorator!");


Coffee coffee = new Coffee();
SugarDecorator coffeeSugar = new SugarDecorator((IBeverage)coffee);
MilkDecorator coffeeSugarMilk = new MilkDecorator((IBeverage)coffeeSugar);

Console.WriteLine($"{coffeeSugarMilk.GetDescription()} - Prix : {coffeeSugarMilk.GetCost()} €");