using System;

namespace NameSorter
{
    public class ArraySorter<T> where T : IComparable<T>
    {
        public void Sort(T[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }

        /*
         * The main function that implements QuickSort() 
         * arr[] --> Array to be sorted, 
         * low --> Starting index, 
         * high --> Ending index 
         */
        private void QuickSort(T[] arr, int low, int high)
        {
            if (low < high)
            {

                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = Partitions(arr, low, high);

                // Recursively sort elements before 
                // partition and after partition 
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }

        /*
         * This function takes last element as pivot, 
         * places the pivot element at its correct 
         * position in sorted array, and places all 
         * smaller (smaller than pivot) to left of 
         * 
         * pivot and all greater elements to right 
         * of pivot 
         */
        private int Partitions(T[] arr, int low, int high)
        {
            T pivot = arr[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                string[] jthArr = arr[j].ToString().Trim().Split(' ');
                string[] pivArr = pivot.ToString().Trim().Split(' ');

                // If current element is smaller than or equal to pivot 
                if (string.Compare(
                        (jthArr[jthArr.Length - 1] + arr[j]),
                        (pivArr[pivArr.Length - 1] + pivot)
                        ) <= 0)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    T ith = arr[i];
                    arr[i] = arr[j];
                    arr[j] = ith;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            T holder = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = holder;

            return i + 1;
        }

        public void BubbleSort(T[] elementArray)
        {

            int listLength = elementArray.Length;
            bool hasSwapped;

            do
            {
                hasSwapped = false;

                for (int i = 1; i < listLength; i++)
                {

                    // swaps unsorted pair
                    if (!IsPairSorted(elementArray[i - 1], elementArray[i]))
                    {
                        T ithName = elementArray[i];
                        elementArray[i] = elementArray[i - 1];
                        elementArray[i - 1] = ithName;
                        hasSwapped = true;
                    }
                }

            } while (hasSwapped);
        }

        private bool IsPairSorted(T precursor, T successor)
        {
            string[] precursorArr = precursor.ToString().Trim().Split(' '); // FIXME change to comparator
            string[] successorArr = successor.ToString().Trim().Split(' '); // FIXME change to comparator

            // compares last names
            return string.Compare(
                    precursorArr[precursorArr.Length - 1] + precursor,
                    successorArr[successorArr.Length - 1] + successor) < 0
                ? true
                : false;
        }
    }
}
