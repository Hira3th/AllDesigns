using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Logic;

internal class ThermometerAdapter : ICelsiusThermometer
{
    private FahrenheitThermometer _fahrenheitThermometer;

    public ThermometerAdapter(FahrenheitThermometer thermometer)
    {
        _fahrenheitThermometer = thermometer;
    }

    public double GetTemperatureInCelsius()
    {
        return (_fahrenheitThermometer.GetTemperature() - 32) * 5 / 9;
    }
}
