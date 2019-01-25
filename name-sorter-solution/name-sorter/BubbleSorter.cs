using System;

namespace NameSorter
{

    public class BubbleSorter
    {
        public void Sort(string[] namesList)
        {

            int listLength = namesList.Length;
            bool hasSwapped;

            do
            {
                hasSwapped = false;

                for (int i = 1; i < listLength; i++)
                {

                    // swaps unsorted pair
                    if (!IsSortedPair(namesList[i - 1], namesList[i]))
                    {
                        string ithName = namesList[i];
                        namesList[i] = namesList[i - 1];
                        namesList[i - 1] = ithName;
                        hasSwapped = true;
                    }
                }

            } while (hasSwapped);
        }

        private bool IsSortedPair(string precursor, string successor)
        {
            string[] precursorArr = precursor.Split(' ');
            string precursorsLastName = precursorArr[precursorArr.Length - 1];

            string[] successorArr = successor.Split(' ');
            string successorsLastName = successorArr[successorArr.Length - 1];

            // compares last names
            if (string.Compare(precursorsLastName, successorsLastName) < 0)
            {
                return true;
            }

            // compares given names
            else if (String.Compare(precursorsLastName, successorsLastName) == 0
                     && String.Compare(precursor, successor) < 0)
            {
                return true;
            }

            return false;
        }
    }

}