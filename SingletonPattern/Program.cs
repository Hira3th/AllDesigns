// See https://aka.ms/new-console-template for more information
using SingletonPattern.Logic;

Console.WriteLine("Hello, Singleton!");

Logger logger1 = Logger.Instance;
Logger logger2 = Logger.Instance;

logger1.Log("Singleton pattern in action!");

Console.WriteLine(Object.ReferenceEquals(logger1, logger2) ?
    "Both are the same instance." : "Different instances.");

Console.ReadLine();