using System;

namespace NameSorter
{

    /*
     * GlobalX Coding Assessment
     * Author: Icaro Muniz
     * Date: 25/01/19
     * 
     * usage: ~$ name-sorter ./unsorted-names-list.txt
     */
    class MainClass
    {
        public static void Main(string[] args)
        {

            const string outputFileName = "sorted-names-list.txt";
            DataHandler dataHandler = new DataHandler();

            // reading data to array
            string[] namesList = dataHandler.ReadData(args[0]);

            // does sorting
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            new ArraySorter<string>().Sort(namesList);
            stopwatch.Stop();

            Console.WriteLine("Sorting time: " + stopwatch.Elapsed + "\n");

            // print sorted list to screen
            dataHandler.PrintToScreen(namesList);

            Console.WriteLine("\nPress any key to write result to the file \"" +
                    outputFileName + "\" and close...");

            dataHandler.PrintToFile(namesList, outputFileName);
            Console.ReadKey();
        }
    }
}
