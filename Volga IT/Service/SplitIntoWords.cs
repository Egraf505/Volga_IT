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
            text = text.Replace("\n", string.Empty);
            text = text.Replace("\r", string.Empty);

            char[] Separators = { ' ', ',', '.', '!', '?', '"', ';', ':', '[', ']', '(', ')', '\n', '\r', '\t' };
            List<Word> words = new List<Word>() { };

            string name = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < Separators.Length; j++)
                {
                    if (text[i] == Separators[j])
                    {
                        if (name.Length > 2 || name == name.ToUpper())
                        {
                            Word wordbuf = new Word { NameWord = name, cout = 1 };

                            if (words.Contains(wordbuf))
                                words[words.IndexOf(wordbuf)].cout++;
                            else
                                words.Add(wordbuf);                                           
                        }
                        name = string.Empty;
                        break;
                    }                    
                }
                name += text[i];
            }
            return words;
        }
    }
}
