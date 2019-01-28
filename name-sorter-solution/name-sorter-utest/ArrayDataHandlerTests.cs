using NUnit.Framework;
using System;

namespace NameSorter.UnitTest
{
    /* methods their tests:
     *  LoadArrayFromFile(string path)
     *      test invalid path
     *      test invalid file content        
     *      test empty lines__    
     *  SendArrayToScreen(string[] dataArray)
     *      test null array
     *      test empty array
     *  SendArrayToFile(string[] dataArray, string path)
     *      test invalid dataArray
     *      test invalid path
     *      test writing        
     */
    [TestFixture()]
    public class ArrayDataHandlerTests
    {

        private ArrayDataHandler _dataHandler;

        [SetUp]
        public void SetUp()
        {
            _dataHandler = new ArrayDataHandler();
        }

        [Test]
        public void LoadArrayFromFile_NoFilePathGiven_ThrowsException()
        {
            Assert.That(() => _dataHandler.LoadArrayFromFile(null),
                Throws.ArgumentNullException);
        }

        [Test]
        public void LoadArrayFromFile_InvalidFilePathGiven_ThrowsException()
        {
            Assert.That(() => _dataHandler.LoadArrayFromFile("xyz.txt"),
                Throws.InstanceOf<System.IO.FileNotFoundException>());
        }

        [Test]
        public void SendArrayToScreen_InvalidArray_ThrowsException()
        {
            Assert.That(() => _dataHandler.LoadArrayFromFile(null),
                Throws.ArgumentNullException);
        }

    }
}
