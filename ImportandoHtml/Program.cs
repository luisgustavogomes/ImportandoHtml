using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportandoHtml
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HtmlDocument doc = new HtmlDocument();
            doc.Load(@"Files\HTMLPage1.html");
            foreach (HtmlNode div in doc.DocumentNode.SelectNodes("//div"))
                    Console.WriteLine(div.InnerText);
        }
    }
}
