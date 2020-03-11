using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAndSearching
{
    public interface ISort
    {
        public void BubbleSort(int[] array);

        public void Marge(int[] array, int left, int middle, int right);

        public void MargeSort(int[] array, int l, int r);

        public void RecursiveBubbleSort(int[] array, int length);

        public void CustomSort(int[] array);

        public void SelectionSort(int[] array);

    }
}
