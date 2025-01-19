using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Models
{
    class DocumentFactory
    {
        public static Document CreateDocument(string type)
        {
            return type.ToLower() switch
            {
                "word" => new WordDocument(),
                "pdf" => new PdfDocument(),
                _ => throw new ArgumentException("Unknown document type")
            };
        }
    }
}
