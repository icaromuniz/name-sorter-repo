using System;

namespace NameSorter
{
    public class SurnameComparator : IComparator<String>
    {

        public int Compare(String fullNameA, String fullNameB)
        {
            var arrayNameA = fullNameA.Trim().Split(' ');
            var arrayNameB = fullNameB.Trim().Split(' ');

            return String.Compare(
                    arrayNameA[arrayNameA.Length - 1] + fullNameA,
                    arrayNameB[arrayNameB.Length - 1] + fullNameB);
        }
    }
}
