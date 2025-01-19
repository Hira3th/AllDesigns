// See https://aka.ms/new-console-template for more information
using StrategyPattern.Logic;

Console.WriteLine("Hello, Strategy!");

List<int> numbers = new List<int> { 34, 7, 23, 32, 5, 62 };

Sorter bubbleSorter = new Sorter(new BubbleSort());
bubbleSorter.Sort(new List<int>(numbers));

Sorter quickSorter = new Sorter(new QuickSort());
quickSorter.Sort(new List<int>(numbers));