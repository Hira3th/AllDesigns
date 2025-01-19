using StrategyPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Logic
{
    internal class QuickSort : ISortingStrategy
    {
        public void Sort(List<int> list)
        {
            Console.WriteLine("Sorting using Quick Sort...");
            list.Sort(); // Simplified for demonstration
        }
    }
}
