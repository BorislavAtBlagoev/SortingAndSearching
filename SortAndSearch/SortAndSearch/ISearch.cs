using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAndSearching
{
    public interface ISearch
    {
        public int BinarySearch(int[] array, int start, int end, int value);

        public bool BooleanBinarySearch(int[] array, int start, int end, int value);

    }
}
