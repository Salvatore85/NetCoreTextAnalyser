using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TextAnalyser.BL;

namespace TextAnalyser.API.Controllers
{
    [Route("api/countwords")]
    public class WordCounterController : Controller
    {
        [HttpPost]
        public string GetAmountOfWords([FromBody] string txt)
        {
            var words = TextStatsGenerator.WordCounter(txt);

            return $"There are {words} words in the giving text.";
        }
    }
}
