using System;
using FactoryMethod.Model;

namespace FactoryMethod.Logic;

public class TextDocument :  Document
{
    public override void Open()
    {
        // Implementation for opening an Excel document
        Console.WriteLine("Opening Text document...");
    }
}
