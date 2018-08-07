using System;

namespace TextAnalyser.BL
{
    class Program
    {
        static void Main(string[] args)
        {
            string testText = "Hallo dit is een test zin.!!";

            var sample = new SortingText();

            var SortedList = sample.Sort(testText, 1);

            foreach (var word in SortedList)
            {
                Console.WriteLine(word);
            }

            Console.ReadLine();
        }
    }
}
