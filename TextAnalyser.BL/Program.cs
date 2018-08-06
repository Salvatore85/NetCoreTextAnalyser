using System;

namespace TextAnalyser.BL
{
    class Program
    {
        static void Main(string[] args)
        {
            string testText = "Hallo dit is een test zin.!!";

            var sample = new TextStatsGenerator();


            Console.WriteLine(sample.SpecialCharactersCounter(testText));

            Console.ReadLine();
        }
    }
}
