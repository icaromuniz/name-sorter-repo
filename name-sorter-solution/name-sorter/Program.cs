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
            var bubbleSorter = new BubbleSorter<string>();

            // reading data to array
            string[] namesList = dataHandler.ReadData(args[0]);

            // does buble sorting
            //bubbleSorter.Sort(namesList);

            // does quick sorting
            int[] intArr = { 10, 80, 30, 90, 40, 50, 70 };
            new ArraySorter<string>().Sort(namesList);
            //foreach (int n in intArr)
            //{
            //    Console.WriteLine(n);
            //}

            dataHandler.PrintToScreen(namesList);
            Console.WriteLine("\nPress any key to write result to the file \"" +
                    outputFileName + "\" and close...");

            dataHandler.PrintToFile(namesList, outputFileName);
            Console.ReadKey();

            new ArraySorter<string>().Sort(namesList);
        }
    }
}
