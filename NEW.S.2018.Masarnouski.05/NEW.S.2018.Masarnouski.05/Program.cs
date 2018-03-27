using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._05
{
    class Program
    {
        static void Main()
        {
            int[][] jaggedArray2 = new int[][]
{
    new int[] {9,5,4,11,3},
    new int[] {2,4,4,6},
    new int[] {22,11}
};
            foreach (var n in jaggedArray2)
            {
                foreach (var v in n)
                {
                    Console.Write(v + " , ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            jaggedArray2 = BubbleSort.SortAscending(jaggedArray2);
            foreach (var n in jaggedArray2)
            {
                foreach (var v in n)
                {
                    Console.Write( v + " , ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
