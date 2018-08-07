using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TextAnalyser.BL
{
    public class TextStatsGenerator
    {
        public static int WordCounter(string txt)
        {
            var words = txt.Split(" ");

            return words.Length;
        }

        public static int SpecialCharactersCounter(string txt)
        {
            var specialCharacters = Regex.Matches(txt, "[(!, -')*]").Count;

            return specialCharacters;
        }

        public static int CountSpaces(string txt)
        {
            int spaces = txt.Count(Char.IsWhiteSpace);

            return spaces;
        }
    }
}
