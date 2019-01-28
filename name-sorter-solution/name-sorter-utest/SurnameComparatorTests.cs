using NUnit.Framework;

namespace NameSorter.UnitTest
{
    [TestFixture()]
    public class SurnameComparatorTests
    {
        private SurnameComparator _comparator;

        [SetUp]
        public void SetUp()
        {
            _comparator = new SurnameComparator();
        }

        [Test()]
        [TestCase("foo", null)]
        [TestCase(null, "foo")]
        public void Compare_NullArgument_ThrowsException(string firstName, string secondName)
        {
            Assert.That(() => _comparator.Compare(firstName, secondName), Throws.Exception);
        }

        [Test]
        public void Compare_FirstNameIsBiggerThanSecondName_ReturnsNegative()
        {
            Assert.That(_comparator.Compare("A", "B"), Is.EqualTo(-1));
        }

        [Test]
        public void Compare_FirstNameIsSmallerThanSecondName_ReturnsPositive()
        {
            Assert.That(_comparator.Compare("B", "A"), Is.EqualTo(1));
        }

        [Test]
        public void Compare_FirstNameIsEqualToSecondName_ReturnZero()
        {
            Assert.That(_comparator.Compare("A", "A"), Is.EqualTo(0));
        }
    }
}
