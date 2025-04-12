// See https://aka.ms/new-console-template for more information
using System.Text; 
using DecoratorPattern.Logic;
using DecoratorPattern.Models;

Console.WriteLine("Hello, Decorator!");


Coffee coffee = new Coffee();
SugarDecorator coffeeSugar = new SugarDecorator(coffee);
MilkDecorator coffeeSugarMilk = new MilkDecorator(coffeeSugar);

Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine($"{coffeeSugarMilk.GetDescription()} - Prix : {coffeeSugarMilk.GetCost()} €");

Console.ReadLine();