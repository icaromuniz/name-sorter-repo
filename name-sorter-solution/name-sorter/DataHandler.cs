using System;

namespace NameSorter
{
    public class DataHandler
    {

        public string[] ReadData(string path)
        {
            return System.IO.File.ReadAllLines(path);
        }

        public void PrintToScreen(string[] dataArray)
        {
            foreach (string name in dataArray)
                Console.WriteLine(name);
        }

        public void PrintToFile(string[] dataArray, string path)
        {
            System.IO.File.WriteAllLines(path, dataArray);
        }
    }
}