using System;
using NUnit.Framework;

namespace NameSorter.UnitTest
{
    [TestFixture()]
    public class GenericArraySorterTests
    {
        [Test()]
        public void Sort_UnsortedList_BecomeSorted()
        {
            var arraySorter = new GenericArraySorter<string>(new FakeSurnameComparator());
            string[] namesList = { "Phil Spencer", "Steve Jobs", "Aaron Jobs" };
            string[] result = { "Aaron Jobs", "Phil Spencer", "Steve Jobs" };

            arraySorter.Sort(namesList);

            Assert.That(result, Is.EqualTo(namesList));
        }

        [Test]
        public void Sort_NullList_ThrowsException()
        {
            var sorter = new GenericArraySorter<string>(new FakeSurnameComparator());

            Assert.That(() => sorter.Sort(null), Throws.Exception);
        }

        [Test]
        public void Sort_NullComparator_ThrowsException()
        {
            Assert.That(() => new GenericArraySorter<string>(null), Throws.ArgumentNullException);
        }
    }
}
