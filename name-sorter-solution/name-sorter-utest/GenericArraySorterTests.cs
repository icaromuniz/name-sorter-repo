using NUnit.Framework;

namespace NameSorter.UnitTest
{
    [TestFixture()]
    public class GenericArraySorterTests
    {
        [Test()]
        public void Sort_UnsortedList_BecomeSorted()
        {
            var arraySorter = new GenericArraySorter<string>(new SurnameComparator());
            string[] namesList = { "Phil Spencer", "Steve Jobs", "Aaron Jobs" };
            string[] result = { "Aaron Jobs", "Steve Jobs", "Phil Spencer" };

            arraySorter.Sort(namesList);

            Assert.That(result, Is.EqualTo(namesList));
        }

        // todo: test array smaller then two items
    }
}
