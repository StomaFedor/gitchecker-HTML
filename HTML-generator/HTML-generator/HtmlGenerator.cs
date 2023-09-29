using Aspose.Html;

namespace HTML_generator
{
    public class HtmlGenerator
    {
        public HtmlGenerator()
        {
            Document = new HTMLDocument();
        }

        public HTMLDocument Document { get; set; }

        public void GenerateHTML(List<string> repoLinks, List<List<string>> matchMatrix)
        {
            CreateHeader("h2", "Gitchecker");
            CreateDatetime();
            CreateRepositories(repoLinks);
            CreateRepoTable(matchMatrix);
            var downloads = Syroot.Windows.IO.KnownFolders.Downloads.Path;
            Document.Save($"{downloads}/gitchecker.html");
        }

        private void CreateHeader(string headerType, string headerText)
        {
            var h2 = (HTMLHeadingElement)Document.CreateElement(headerType);
            var text = Document.CreateTextNode(headerText);
            h2.AppendChild(text);
            Document.Body.AppendChild(h2);
        }

        private void CreateParagraph(string parText)
        {
            var paragraph = (HTMLParagraphElement)Document.CreateElement("p");
            var text = Document.CreateTextNode(parText);
            paragraph.AppendChild(text);
            Document.Body.AppendChild(paragraph);
        }

        private void CreateDatetime()
        {
            CreateHeader("h3", "Дата и время");
            var paragraph = (HTMLParagraphElement)Document.CreateElement("p");
            var text = Document.CreateTextNode(DateTime.Now.ToString());
            paragraph.AppendChild(text);
            Document.Body.AppendChild(paragraph);
        }

        private void CreateRepositories(List<string> repoLinks)
        {
            CreateHeader("h3", "Репозитории");
            CreateParagraph($"Количество: {repoLinks.Count}");

            var list = (HTMLOListElement)Document.CreateElement("ol");

            foreach (string repoLink in repoLinks)
            {
                var item = (HTMLLIElement)Document.CreateElement("li");
                item.AppendChild(Document.CreateTextNode(repoLink));
                list.AppendChild(item);
            }
            Document.Body.AppendChild(list);
        }

        private void CreateRepoTable(List<List<string>> matchMatrix)
        {
            CreateHeader("h3", "Результаты проверки репозиториев");
            var htmlTable = "<table style=\"border-collapse: collapse;\"><tbody><tr>";
            htmlTable += "<th scope=\"col\">repo num</th>";
            for (int i = 1; i < matchMatrix.Count + 1; i++)
            {
                htmlTable += $"<th scope=\"col\" style=\"border: 1px solid black;\">{i}</th>";
            }
            htmlTable += "</tr>";
            var count = 1;
            foreach (var match in matchMatrix)
            {
                htmlTable += $"<tr><th scope=\"row\" style=\"border: 1px solid black;\">{count}</th>";
                foreach (var item in match)
                {
                    htmlTable += $"<td style=\"border: 1px solid black;\">{item}</td>";
                }
                count++;
                htmlTable += "</tr>";
            }
            htmlTable += "</tbody></table>";
            Document.Body.InnerHTML += htmlTable;
        }
    }
}
