using System;

namespace NameSorter
{

    public class BubbleSorter<T> where T : IComparable<T>
    {
        public void Sort(T[] elementArray)
        {

            int listLength = elementArray.Length;
            bool hasSwapped;

            do
            {
                hasSwapped = false;

                for (int i = 1; i < listLength; i++)
                {

                    // swaps unsorted pair
                    if (!IsSortedPair(elementArray[i - 1], elementArray[i]))
                    {
                        T ithName = elementArray[i];
                        elementArray[i] = elementArray[i - 1];
                        elementArray[i - 1] = ithName;
                        hasSwapped = true;
                    }
                }

            } while (hasSwapped);
        }

        private bool IsSortedPair(T precursor, T successor)
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