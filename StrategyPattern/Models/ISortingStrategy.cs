﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Models;

public interface ISortingStrategy
{
    void Sort(List<int> list);
}
