using System;
using System.Linq;
using NUnit.Framework;
using NEW.S._2018.Masarnouski._05.Buble.Sort.Comparators;
using NEW.S._2018.Masarnouski._05;

namespace NEW.S_2018.Masarnouski_05.Tests
{
    [TestFixture]
class DelegateBubleSortTest
{
    [Test]
    public void DelegateBubleSort_SumRowSort_ArgumentsTest_SortedArrayReturned()
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

        Comparison<int[]> comparison = (first, second) => { return first.Sum().CompareTo(second.Sum()); };

        DelegateBubleSort.SumRowSort(jaggedArrayUnsorted, comparison);

        for (int i = 0; i < jaggedArrayUnsorted.Length; i++)
        {
            for (int j = 0; j < jaggedArraySorted[i].Length; j++)
            {
                Assert.AreEqual(jaggedArraySorted[i][j], jaggedArrayUnsorted[i][j]);
            }
        }
    }
    [Test]
    public void DelegateBubleSort_NullArgumentTest_ArgNullExceptionReturned()
    {
        int[][] jaggedArrayUnsorted = null;

        Comparison<int[]> comparison = (first, second) => { return first.Sum().CompareTo(second.Sum()); };
        Assert.Throws<ArgumentNullException>(() => DelegateBubleSort.SumRowSort(jaggedArrayUnsorted, comparison));
    }
    [Test]
    public void DelegateBubleSort_ArgumentLengthIsZeroTest_ArgExceptionReturned()
    {
        int[][] jaggedArrayUnsorted = new int[0][]
         {};
        Comparison<int[]> comparison = (first, second) => { return first.Sum().CompareTo(second.Sum()); };

        Assert.Throws<ArgumentException>(() => DelegateBubleSort.SumRowSort(jaggedArrayUnsorted, comparison));
    }
}
}


