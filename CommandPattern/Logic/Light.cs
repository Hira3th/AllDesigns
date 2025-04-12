using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Logic
{
    public class Light
    {
        public void TurnOn() => Console.WriteLine("La lumière est allumée.");
        public void TurnOff() => Console.WriteLine("La lumière est éteinte.");
    }
}
