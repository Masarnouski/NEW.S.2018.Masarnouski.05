using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._05.Buble.Sort.Comparators
{
    class DelegateComparator : IComparer<int[]>
    {
        private Comparison<int[]> comparison;

        public DelegateComparator(Comparison<int[]> comparison)
        {
            this.comparison = comparison;
        }

        public int Compare(int[] first, int[] second)
        {
           return comparison(first, second);
        }
    }
}
