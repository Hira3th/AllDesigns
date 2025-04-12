// See https://aka.ms/new-console-template for more information
using StrategyPattern.Logic;

Console.WriteLine("Hello, Strategy!");

List<int> numbers = new List<int> { 34, 7, 23, 32, 5, 62 };

// Display the original list
Console.WriteLine("Original list: " + string.Join(", ", numbers));

Sorter bubbleSorter = new Sorter(new BubbleSort());
bubbleSorter.Sort(numbers);

// Display the bubble sorted list
Console.WriteLine("Bubble list: " + string.Join(", ", numbers));

Sorter quickSorter = new Sorter(new QuickSort());
quickSorter.Sort(numbers);

// Display the quick sorted list
Console.WriteLine("Quick list: " + string.Join(", ", numbers));

Console.ReadLine();