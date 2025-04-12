using FactoryMethod.Model;

namespace FactoryMethod.Logic;

public class PdfDocument : Document
{
    public override void Open()
    {
        Console.WriteLine("Opening PDF document");
    }
}
