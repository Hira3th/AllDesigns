using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Logic;

public class FahrenheitThermometer
{
    public double GetTemperature()
    {
        return 98.6; // Température en Fahrenheit
    }
}

