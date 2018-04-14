using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._05.Buble.Sort.Comparators
{
    class Comparator : IComparer<int[]>
    {
        public int Compare(int[] first, int[] second)
        {
            if (first.Sum() > second.Sum())
                return 1;
            if (first.Sum() < second.Sum())
                return -1;
            if (first.Sum() == second.Sum())
                return 0;
            else
                throw new Exception();
        }
    }
}
        

