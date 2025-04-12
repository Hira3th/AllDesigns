using FactoryMethod.Model;

namespace FactoryMethod.Logic;

public class WordDocument : Document
{
    public override void Open()
    {
        Console.WriteLine("Opening Word document");
    }
}
