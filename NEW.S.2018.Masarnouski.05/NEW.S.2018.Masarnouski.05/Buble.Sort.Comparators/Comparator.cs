﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._05.Buble.Sort.Comparators
{
    public class Comparator : IComparer<int[]>
    {
        public int Compare(int[] first, int[] second)
        {
           return first.Sum().CompareTo(second.Sum());
        }
    }
}
        

