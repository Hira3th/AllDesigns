using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Model;

namespace FactoryMethod.Logic;

public class DocumentFactory
{
    public static Document CreateDocument(string type)
    {
        return type.ToLower() switch
        {
            "word" => new WordDocument(),
            "pdf" => new PdfDocument(),
            "excel" => new ExcelDocument(),
            "text" => new TextDocument(),
            _ => throw new ArgumentException("Unknown document type")
        };
    }
}
