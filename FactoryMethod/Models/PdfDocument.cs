using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Models
{
    class PdfDocument : Document
    {
        public override void Open()
        {
            Console.WriteLine("Opening PDF document");
        }
    }
}
