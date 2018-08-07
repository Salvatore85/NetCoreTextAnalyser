using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TextAnalyser.BL;

namespace TextAnalyser.API.Controllers
{
    [Route("api/countpuncmarks")]
    public class PunctuationMarksCounter : Controller
    {
        [HttpPost]
        public string GetAmountOfPunctuationMarks([FromBody] string txt)
        {
            var punc = TextStatsGenerator.SpecialCharactersCounter(txt);

            return $"There are {punc} punctuation marks in the giving text.";
        }
    }
}
