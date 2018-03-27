using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._05
{
    class BubbleSort
    {
        public static int[][] SortAscending(int[][] arr)
        {
            if (arr is null)
            {
                throw new ArgumentNullException(nameof(arr));
            }
            for (int p = 0; p <= arr.Length - 1; p++)
            {
                for (int f = 0; f <= arr.Length - 1; f++)
                {
                    for (int i = 0; i < arr[f].Length - 1; i++)
                    {
                        if (arr[f][i] > arr[f][i + 1])
                        {
                            int buf = arr[f][i];
                            arr[f][i] = arr[f][i + 1];
                            arr[f][i + 1] = buf;
                        }
                    }
                }
            }
            return arr;
        }
        public static int[][] SortDescending(int[][] arr)
        {
            if (arr is null)
            {
                throw new ArgumentNullException(nameof(arr));
            }
            for (int f = 0; f <= arr.Length - 1; f++)
            {
                for (int p = 0; p <= arr[f].Length - 1; p++)
                {
                    for (int i = 0; i < arr[f].Length - 1; i++)
                    {
                        if (arr[f][i] < arr[f][i + 1])
                        {
                            int buf = arr[f][i + 1];
                            arr[f][i + 1] = arr[f][i];
                            arr[f][i] = buf;
                        }
                    }
                }
            }
            return arr;
        }
    }
}
