using HtmlAgilityPack;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;

namespace ImportandoHtml
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //ReadHtml();
            WritePdf();
        }

        private static void ReadHtml()
        {
            HtmlDocument doc = new HtmlDocument();
            doc.Load(@"Files\HTMLPage1.html");
            foreach (HtmlNode div in doc.DocumentNode.SelectNodes("//div"))
                Console.WriteLine(div.InnerText);
        }


        private static void WritePdf()
        {
            FileStream fs = new FileStream(@"Files\MyPDF.pdf", FileMode.Create, FileAccess.Write, FileShare.None);
            Document doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, fs);
            doc.Open();
            doc.Add(new Paragraph("C# é Top Zé Roela!!!"));
            doc.Close();
        }
    }
}
