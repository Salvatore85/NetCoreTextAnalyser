using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TextAnalyser.BL
{
    class TextStatsGenerator
    {
        public int WordCounter(string txt)
        {
            var words = txt.Split(" ");

            return words.Length;
        }

        public int SpecialCharactersCounter(string txt)
        {
            var specialCharacters = Regex.Matches(txt, "[(!, -')*]").Count;

            return specialCharacters;
        }
    }
}
