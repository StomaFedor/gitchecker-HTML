using Aspose.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlBuilder
{
    public class HtmlGenerator
    {
        public HtmlGenerator()
        {
            Document = new HTMLDocument();
        }

        public HTMLDocument Document { get; set; }

        public void CreateHeader(string headerType, string headerText)
        {
            var h2 = (HTMLHeadingElement)Document.CreateElement(headerType);
            var text = Document.CreateTextNode(headerText);
            h2.AppendChild(text);
            Document.Body.AppendChild(h2);
        }

        public void CreateParagraph(string parText)
        {
            var paragraph = (HTMLParagraphElement)Document.CreateElement("p");
            var text = Document.CreateTextNode(parText);
            paragraph.AppendChild(text);
            Document.Body.AppendChild(paragraph);
        }

        public void CreateDatetime()
        {
            var paragraph = (HTMLParagraphElement)Document.CreateElement("p");
            var text = Document.CreateTextNode(DateTime.Now.ToString());
            paragraph.AppendChild(text);
            Document.Body.AppendChild(paragraph);
        }

        public void CreateList(List<string> list)
        {
            CreateParagraph($"Количество: {list.Count}");

            var htmlList = (HTMLOListElement)Document.CreateElement("ol");

            foreach (string repoLink in list)
            {
                var item = (HTMLLIElement)Document.CreateElement("li");
                item.AppendChild(Document.CreateTextNode(repoLink));
                htmlList.AppendChild(item);
            }
            Document.Body.AppendChild(htmlList);
        }

        public void CreateTable(List<List<string>> matrix)
        {
            var tBuilder = new TableBuilder();
            List<int> colRowNums = Enumerable.Range(1, matrix.Count).ToList();
            Document.Body.InnerHTML += tBuilder.CreateTable(colRowNums.Select(s => s.ToString()).ToList(),
                                                            colRowNums.Select(s => s.ToString()).ToList(),
                                                            matrix);
        }

        public void Save()
        {
            var downloads = Syroot.Windows.IO.KnownFolders.Downloads.Path;
            Document.Save($"{downloads}/gitchecker.html");
        }
    }
}
