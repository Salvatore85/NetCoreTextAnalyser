using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TextAnalyser.BL;

namespace TextAnalyser.API.Controllers
{
    [Route("api/countspaces")]
    public class SpacesCounterController : Controller
    {
        [HttpPost]
        public string GetAmountOfSpaces([FromBody] string txt)
        {
            var spaces = TextStatsGenerator.CountSpaces(txt);

            return $"There are {spaces} spaces in the giving text.";
        }
    }
}
