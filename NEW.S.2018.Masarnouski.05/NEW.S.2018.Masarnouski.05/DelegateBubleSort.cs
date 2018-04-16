using NEW.S._2018.Masarnouski._05.Buble.Sort.Comparators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._05
{
    public class DelegateBubleSort
    {
        /// <summary>
        /// Sorts in order of increasing sum of subarrays
        /// </summary>
        /// <param name="jaggedArray">Unsorted jaggedarray </param>
        public static void SumRowSort(int[][] jaggedArray, Comparison<int[]> comparison)
        {
            if (jaggedArray is null)
                throw new ArgumentNullException(nameof(jaggedArray));

            if (jaggedArray.Length < 1)
                throw new ArgumentException($"JaggedArray {nameof(jaggedArray)} must have at least 1 row");

            SumRowSort(jaggedArray, new DelegateComparator(comparison));
        }

        private static void SumRowSort(int[][] jaggedArray, IComparer<int[]> comparer )
        {
            int[] temp = new int[jaggedArray.Length];
            for (int i = 0; i < jaggedArray.Length - 1; i++)
            {
                for (int j = i + 1; j < jaggedArray.Length; j++)
                {
                    if (comparer.Compare(jaggedArray[i],jaggedArray[j]) == 1)
                    {
                        temp = jaggedArray[i];
                        jaggedArray[i] = jaggedArray[j];
                        jaggedArray[j] = temp;
                    }
                }
            }
        }
    }
}
