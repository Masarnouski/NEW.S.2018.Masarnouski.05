using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubleSort
{
    public class BubleSort
    {
        /// <summary>
        /// Sorts the elements in each subarray of a jagged array
        /// </summary>
        /// <param name="jaggedArray"> Unsorted jaggedarray </param>
        public static void Sort(ref int[][] jaggedArray)
        {
            if (jaggedArray is null)
                throw new ArgumentNullException(nameof(jaggedArray));
            if (jaggedArray.Length < 1)
                throw new ArgumentException($"JaggedArray {nameof(jaggedArray)} must have at least 1 row");

            for (int i = 0; i < jaggedArray.Length; i++)

                Sort(ref jaggedArray[i]);
        }

        /// <summary>
        /// Sorts in order of increasing sum of subarrays
        /// </summary>
        /// <param name="jaggedArray">Unsorted jaggedarray </param>
        public static void SumRowSort(ref int[][] jaggedArray)
        {
            if (jaggedArray is null)
                throw new ArgumentNullException(nameof(jaggedArray));

            if (jaggedArray.Length < 1)
                throw new ArgumentException($"JaggedArray {nameof(jaggedArray)} must have at least 1 row");

            int[] temp = new int[jaggedArray.Length];
            for (int i = 0; i < jaggedArray.Length - 1; i++)
            {
                for (int j = i + 1; j < jaggedArray.Length; j++)
                {
                    if (jaggedArray[i].Sum() > jaggedArray[j].Sum())
                    {
                        temp = jaggedArray[i];
                        jaggedArray[i] = jaggedArray[j];
                        jaggedArray[j] = temp;
                    }
                }
            }
        }

        private static void Sort(ref int[] subArray)
        {
            if (subArray is null)
             throw new ArgumentNullException(nameof(subArray));

            int temp;
            for (int i = 0; i < subArray.Length - 1; i++)
            {
                for (int j = i + 1; j < subArray.Length; j++)
                {
                    if (subArray[i] > subArray[j])
                    {
                        temp = subArray[i];
                        subArray[i] = subArray[j];
                        subArray[j] = temp;
                    }
                }
            }

        }
    }
}
