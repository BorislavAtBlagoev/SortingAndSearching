using System;
using System.Diagnostics;

namespace SortingAndSearching
{
    public class Sort : ISort
    {
        void ISort.BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        void ISort.Marge(int[] array, int left, int middle, int right)
        {
            int leftArraySize = middle - left + 1;
            int rightArraySize = right - middle;

            int[] leftArray = new int[leftArraySize];
            int[] rightArray = new int[rightArraySize];

            for (int indexL = 0; indexL < leftArraySize; indexL++)
            {
                leftArray[indexL] = array[left + indexL];
            }

            for (int indexR = 0; indexR < rightArraySize; indexR++)
            {
                rightArray[indexR] = array[middle + 1 + indexR];
            }

            int i = 0, j = 0;
            int k = left;

            while (i < leftArraySize && j < rightArraySize)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            while (i < leftArraySize)
            {
                array[k] = leftArray[i];
                i++;
                k++;
            }

            while (j < rightArraySize)
            {
                array[k] = rightArray[j];
                j++;
                k++;
            }
        }

        void ISort.MargeSort(int[] array, int l, int r)
        {
            if (l < r)
            {
                // Find the middle point 
                int m = (l + r) / 2;

                // Sort first and second halves 
                MargeSort(array, l, m);
                MargeSort(array, m + 1, r);

                // Merge the sorted halves 
                Marge(array, l, m, r);
            }
        }

        void ISort.RecursiveBubbleSort(int[] array, int length)
        {
            if (length == 1)
            {
                return;
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    int temp = array[i + 1];
                    array[i + 1] = array[i];
                    array[i] = temp;
                }
            }

            RecursiveBubbleSort(array, length - 1);
        }

        void ISort.CustomSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }
        }

        void ISort.SelectionSort(int[] array)
        {
            for (int index = 0; index < array.Length - 1; index++)
            {
                int minIndex = index;

                for (int currentIndex = index + 1; currentIndex < array.Length; currentIndex++)
                {
                    if (array[minIndex] > array[currentIndex])
                    {
                        minIndex = currentIndex;
                    }
                }

                int temp = array[minIndex];
                array[minIndex] = array[index];
                array[index] = temp;
            }
        }

        private void Marge(int[] array, int left, int middle, int right)
        {

            int leftArraySize = middle - left + 1;
            int rightArraySize = right - middle;

            int[] leftArray = new int[leftArraySize];
            int[] rightArray = new int[rightArraySize];

            for (int indexL = 0; indexL < leftArraySize; indexL++)
            {
                leftArray[indexL] = array[left + indexL];
            }

            for (int indexR = 0; indexR < rightArraySize; indexR++)
            {
                rightArray[indexR] = array[middle + 1 + indexR];
            }

            int i = 0, j = 0;
            int k = left;

            while (i < leftArraySize && j < rightArraySize)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            while (i < leftArraySize)
            {
                array[k] = leftArray[i];
                i++;
                k++;
            }

            while (j < rightArraySize)
            {
                array[k] = rightArray[j];
                j++;
                k++;
            }
        }

        private void MargeSort(int[] array, int l, int r)
        {
            if (l < r)
            {
                // Find the middle point 
                int m = (l + r) / 2;

                // Sort first and second halves 
                MargeSort(array, l, m);
                MargeSort(array, m + 1, r);

                // Merge the sorted halves 
                Marge(array, l, m, r);
            }
        }

        private void RecursiveBubbleSort(int[] array, int length)
        {
            if (length == 1)
            {
                return;
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    int temp = array[i + 1];
                    array[i + 1] = array[i];
                    array[i] = temp;
                }
            }

            RecursiveBubbleSort(array, length - 1);
        }

    }
}

