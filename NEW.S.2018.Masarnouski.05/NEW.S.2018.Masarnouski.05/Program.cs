using NEW.S._2018.Masarnouski._05.Buble.Sort.Comparators;
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
            Comparator newComparator = new Comparator();
            int[][] jaggedArrayUnsorted = new int[][]
            {
                new int[]{ -5,3,5,0,17},
                new int[]{ 130, 11},
                new int[]{ 9,5,5,0 }
            };
            foreach (var n in jaggedArrayUnsorted)
            {
                foreach (var c in n)
                {
                    Console.Write(c + " ");
                }
                Console.WriteLine();
            }

            Array.Sort(jaggedArrayUnsorted, newComparator);
            foreach (var n in jaggedArrayUnsorted)
            {
                foreach (var c in n)
                {
                    Console.Write(c + " ");
                    
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
