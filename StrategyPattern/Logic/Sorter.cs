using StrategyPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Logic
{
    internal class Sorter
    {
        private ISortingStrategy sortingStrategy;

        public Sorter(ISortingStrategy strategy)
        {
            sortingStrategy = strategy;
        }

        public void Sort(List<int> list)
        {
            sortingStrategy.Sort(list);
        }
    }
}
