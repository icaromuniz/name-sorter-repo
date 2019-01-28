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
            var dataHandler = new ArrayDataHandler();

            // creates a sorter specifying a particular comparator
            var nameListSorter = new GenericArraySorter<string>(new SurnameComparator());

            // loading data from file to array
            string[] namesList = dataHandler.LoadArrayFromFile(args[0]);

            // does the sorting
            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            nameListSorter.Sort(namesList);
            stopwatch.Stop();

            // prints sorted list to screen
            Console.WriteLine("Sorting time: " + stopwatch.Elapsed + "\n");
            dataHandler.SendArrayToScreen(namesList);

            // prints sorted list to output file
            Console.WriteLine("\nPress any key to write result to the file \"" +
                    outputFileName + "\" and close...");
            dataHandler.SendArrayToFile(namesList, outputFileName);

            Console.ReadKey();
        }
    }
}
