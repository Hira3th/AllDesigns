using System;
using FactoryMethod.Model;

namespace FactoryMethod.Logic;

public class ExcelDocument : Document
{
    public override void Open()
    {
        // Implementation for opening an Excel document
        Console.WriteLine("Opening Excel document...");
    }
}
