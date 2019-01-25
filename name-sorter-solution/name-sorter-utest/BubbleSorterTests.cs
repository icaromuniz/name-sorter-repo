using NUnit.Framework;

namespace NameSorter.UnitTest
{
    [TestFixture()]
    public class BubbleSorterUTest
    {
        [Test()]
        public void Sort_UnsortedList_BecomeSorted()
        {
            BubbleSorter bubbleSorter = new BubbleSorter();
            string[] namesList = { "Phil Spencer", "Steve Jobs", "Aaron Jobs" };
            string[] result = { "Aaron Jobs", "Steve Jobs", "Phil Spencer" };

            bubbleSorter.Sort(namesList);

            Assert.That(result, Is.EqualTo(namesList));
        }
    }
}
