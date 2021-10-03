using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Volga_IT
{
    class HtmlParser
    {
        public string Parser(string path)
        {
            try
            {
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.Load(path, Encoding.UTF8);
                return doc.DocumentNode.InnerText;
            }
            catch (Exception ex) {Console.WriteLine(ex.Message);}

            return null;
        }
    }
}
