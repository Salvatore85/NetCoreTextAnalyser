using System;
using System.Security.Authentication.ExtendedProtection;
using Microsoft.Extensions.DependencyInjection;

namespace TextAnalyser.BL
{
    class Program
    {
        static void Main(string[] args)
        {
            //DI Setup
            var serviceProvider = new ServiceCollection();

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
