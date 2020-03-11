using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAndSearching
{
    public class Search : ISearch
    {
        int ISearch.BinarySearch(int[] array, int start, int end, int value)
        {
            while (start <= end)
            {
                int middle = (end + start) / 2;

                if (array[middle] == value)
                {
                    return middle;
                }
                else if (array[middle] > value)
                {
                    end = middle - 1;
                }
                else if (array[middle] < value)
                {
                    start = middle + 1;
                }
            }

            throw new Exception();
        }

        bool ISearch.BooleanBinarySearch(int[] array, int start, int end, int value)
        {
            while (start <= end)
            {
                int middle = (end + start) / 2;

                if (array[middle] == value)
                {
                    return true;
                }
                else if (array[middle] > value)
                {
                    end = middle - 1;
                }
                else if (array[middle] < value)
                {
                    start = middle + 1;
                }
            }

            return false;
        }
    }
}
