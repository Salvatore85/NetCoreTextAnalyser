using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextAnalyser.BL
{
    public class SortingText
    {
        public static List<string> Sort(string txt, int option)
        {
            switch (option)
            {
                case 1:
                {
                    var words = txt.Split().ToArray();
                    var wordsList = words.ToList();

                    return wordsList;
                }
                case 2:
                {
                    var words = txt.Split().ToArray();
                    var wordsList = words.ToList();
                    var listSortDescending = wordsList.OrderByDescending(w => w).ToList();

                    return listSortDescending;
                }
                case 3:
                {
                    var words = txt.Split().ToArray();
                    var wordsList = words.ToList();
                    var listSortAscending = wordsList.OrderBy(w => w).ToList();

                    return listSortAscending;
                }
                default:
                    break;
            }

            return null;
        }
    }
}
