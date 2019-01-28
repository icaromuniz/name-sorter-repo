using System;

namespace NameSorter
{
    public class GenericArraySorter<T> where T : IComparable<T>
    {
        private readonly IComparator<T> _comparator;

        public GenericArraySorter(IComparator<T> comparator) => _comparator = comparator;

        public void Sort(T[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }

        private void QuickSort(T[] array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {

                int pi = Partitions(array, lowIndex, highIndex);

                QuickSort(array, lowIndex, pi - 1);
                QuickSort(array, pi + 1, highIndex);
            }
        }

        private int Partitions(T[] array, int lowIndex, int highIndex)
        {
            T pivot = array[highIndex];

            // index of smaller element 
            int i = (lowIndex - 1);
            for (int j = lowIndex; j < highIndex; j++)
            {
                string[] jthArr = array[j].ToString().Trim().Split(' ');
                string[] pivArr = pivot.ToString().Trim().Split(' ');

                // If current element is smaller than or equal to pivot 
                if(_comparator.Compare(array[j], pivot) <= 0)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    T ith = array[i];
                    array[i] = array[j];
                    array[j] = ith;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            T holder = array[i + 1];
            array[i + 1] = array[highIndex];
            array[highIndex] = holder;

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
            // compares last names
            return _comparator.Compare(precursor, successor) < 0;
        }
    }
}
