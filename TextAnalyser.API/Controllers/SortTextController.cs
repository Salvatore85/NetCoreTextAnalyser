using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TextAnalyser.BL;

namespace TextAnalyser.API.Controllers
{
    [Route("api/sortext")]
    public class SortTextController
    {
        [HttpPost("{option}")]
        public List<string> GetAmountOfSpaces([FromBody] string txt, int option)
        {
            return SortingText.Sort(txt, option);
        }
    }
}
