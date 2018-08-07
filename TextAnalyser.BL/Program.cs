using System;
using Microsoft.Extensions.DependencyInjection;

namespace TextAnalyser.BL
{
    class Program
    {
        static void Main(string[] args)
        {
            string testText = "Hallo dit is een test zin.!!";

            //var sample = new SortingText();

            var sortedList = SortingText.Sort(testText, 1);

            foreach (var word in sortedList)
            {
                Console.WriteLine(word);
            }

            Console.ReadLine();
        }
    }
}
