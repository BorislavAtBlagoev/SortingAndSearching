using SortingAndSearching;
using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 4, 2, 1, 5, 10, -10, -50, 101, -59, 10, 0, 1000, -10000, -500, 100, 99, 78, 11, 0, 10000, 56, 48, -89, 15, 23, 45, 78, 89, 10, 26, 49, 78, 19, -125, -50, -99 };
            ISort sort = new Sort();
            ISearch search = new Search();
            sort.BubbleSort(array);
            int index = search.BinarySearch(array, 0, array.Length, 0);
            Console.WriteLine(index);
        }
    }
}
