using System;

namespace NameSorter
{
    public class ArrayDataHandler
    {

        public string[] LoadArrayFromFile(string path)
        {
            return System.IO.File.ReadAllLines(path);
        }

        public void SendArrayToScreen(string[] dataArray)
        {
            foreach (string name in dataArray)
                Console.WriteLine(name);
        }

        public void SendArrayToFile(string[] dataArray, string path)
        {
            System.IO.File.WriteAllLines(path, dataArray);
        }
    }
}