// See https://aka.ms/new-console-template for more information
using AdapterPattern.Logic;
using AdapterPattern.Models;

Console.WriteLine("Hello, Adapter!");

FahrenheitThermometer oldThermometer = new FahrenheitThermometer();
ICelsiusThermometer adaptedThermometer = new ThermometerAdapter(oldThermometer);

Console.WriteLine($"Température en Celsius : {adaptedThermometer.GetTemperatureInCelsius()} °C");