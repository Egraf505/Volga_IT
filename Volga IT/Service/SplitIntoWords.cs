using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volga_IT.Models;

namespace Volga_IT
{
    class SplitIntoWords
    {
        public List<Word> BreakerText(string text)
        {        
            char[] Separators = { ' ', ',', '.', '!', '?', '"', ';', ':', '[', ']', '(', ')', '\n', '\r', '\t','\0'};
            List<Word> words = new List<Word>() { };

            string[] array = text.Split(Separators);

            foreach (var item in array)
            {
                if (item.Length > 3 || item == item.ToUpper() && item != "")
                {
                    Word bufword = new Word { NameWord = item, cout = 1 };
                    if (words.Contains(bufword))
                        words[words.IndexOf(bufword)].cout++;
                    else
                        words.Add(bufword);
                }
            }       
            return words;
        }
    }
}
