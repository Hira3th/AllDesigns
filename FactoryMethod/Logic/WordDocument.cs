using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Model;

namespace FactoryMethod.Logic;

public class WordDocument : Document
{
    public override void Open()
    {
        Console.WriteLine("Opening Word document");
    }
}
