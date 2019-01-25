using NameSorter;
using NUnit.Framework;

namespace nameSorterUTest
{
    [TestFixture()]
    public class DataHandlerUTest
    {

        private DataHandler _dataHandler;

        [SetUp]
        public void SetUp()
        {
            _dataHandler = new DataHandler();
        }

        [Test]
        public void ReadData_NoFilePathGiven_ThrowsException()
        {
            Assert.That(() => _dataHandler.ReadData(null), Throws.ArgumentNullException);
        }

        [Test]
        public void ReadData_InvalidFilePathGiven_ThrowsException()
        {
            Assert.That(() => _dataHandler.ReadData("xyz.txt"), Throws.InstanceOf<System.IO.FileNotFoundException>());
        }
    }
}
