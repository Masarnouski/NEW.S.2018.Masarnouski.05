using System;
using NUnit.Framework;

namespace BubleSort.Tests
{
    [TestFixture]
    public class BubleSort_Test
    {
       
        [Test]
        public void Sort_ArgumentsTest_SortedArrayReturned()
        {
            int[][] jaggedArrayUnsorted = new int[][]
           {
                new int[]{ -5,3,5,0,17},
                new int[]{ 130, 11},
                new int[]{ 9,5,5,0 }
           };
            int[][] jaggedArraySorted = new int[][]
            {
                new int[]{ -5,0,3,5,17},
                new int[]{ 11, 130},
                new int[]{ 0,5,5,9 }
            };
            BubleSort.Sort(jaggedArrayUnsorted);
            for (int i = 0; i < jaggedArrayUnsorted.Length; i++)
            {
                for (int j = 0; j < jaggedArraySorted[i].Length; j++)
                {
                    Assert.AreEqual(jaggedArraySorted[i][j], jaggedArrayUnsorted[i][j]);
                }
            }
        }
        [Test]
        public void Sort_NulSubArrayTest_ArgNullExceptionReturned()
        {
            int[][] jaggedArrayUnsorted = new int[][]
            {
                null,
                new int[]{ 130, 11},
                new int[]{ 9,5,5,0 }
            };

            Assert.Throws<ArgumentNullException>(() => BubleSort.Sort(jaggedArrayUnsorted));
        }

        [Test]
        public void Sort_NullArgumentTest_ArgNullExceptionReturned()
        {
            int[][] jaggedArrayUnsorted = null;
          

            Assert.Throws<ArgumentNullException>(() => BubleSort.Sort(jaggedArrayUnsorted));
        }
        [Test]
        public void Sort_ArgumentLengthIsZeroTest_ArgExceptionReturned()
        {
            int[][] jaggedArrayUnsorted = new int[0][]
             {};

            Assert.Throws<ArgumentException>(() => BubleSort.Sort(jaggedArrayUnsorted));
        }

        [Test]
        public void SumRowSort_ArgumentsTest_SortedArrayReturned()
        {
            int[][] jaggedArrayUnsorted = new int[][]
           {
                new int[]{ -5,3,5,0,17},
                new int[]{ 130, 11},
                new int[]{ 9,5,5,0 }
           };
            int[][] jaggedArraySorted = new int[][]
            {
                new int[]{ 9,5,5,0 },
                new int[]{ -5,3,5,0,17},
                new int[]{ 130, 11}
            };

            BubleSort.SumRowSort(jaggedArrayUnsorted);
            for (int i = 0; i < jaggedArrayUnsorted.Length; i++)
            {
                for (int j = 0; j < jaggedArraySorted[i].Length; j++)
                {
                    Assert.AreEqual(jaggedArraySorted[i][j], jaggedArrayUnsorted[i][j]);
                }
            }
        }
        [Test]
        public void SumRowSort_NullArgumentTest_ArgNullExceptionReturned()
        {
            int[][] jaggedArrayUnsorted = null;


            Assert.Throws<ArgumentNullException>(() => BubleSort.SumRowSort(jaggedArrayUnsorted));
        }
        [Test]
        public void SumRowSort_ArgumentLengthIsZeroTest_ArgExceptionReturned()
        {
            int[][] jaggedArrayUnsorted = new int[0][]
             {};

            Assert.Throws<ArgumentException>(() => BubleSort.SumRowSort(jaggedArrayUnsorted));
        }
    }
}
