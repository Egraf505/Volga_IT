using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volga_IT.Models;

namespace Volga_IT.Service
{
    class OutToText
    {
        public void WriteText(List<Word> words, string path)
        {
            FileInfo file = new FileInfo(path);
            if (!file.Exists)
            {
                using(StreamWriter writer = file.CreateText())
                {
                    for (int i = 0; i < words.Count; i++)
                    {
                        writer.WriteLine($"{words[i].NameWord} - {words[i].cout}");
                    }
                }
            }
        }
    }
}
