using NameSorter;
using NUnit.Framework;

namespace NameSorter.UnitTest
{
    public class FakeSurnameComparator : IComparator<string>
    {
        public int Compare(string arg1, string arg2)
        {
            return string.Compare(arg1, arg2);
        }
    }
}
