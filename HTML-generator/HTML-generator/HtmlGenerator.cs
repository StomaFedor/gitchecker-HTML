using Aspose.Html;

namespace HTML_generator
{
    public class HtmlGenerator
    {
        public HtmlGenerator()
        {
            Document = new HTMLDocument();
            CreateHeader("h2", "Gitchecker");
        }

        public HTMLDocument Document { get; set; }

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
            var paragraph = (HTMLParagraphElement)Document.CreateElement("p");
            var data = DateTime.UtcNow.ToString();
            var text = Document.CreateTextNode(data);
            paragraph.AppendChild(text);
            Document.Body.AppendChild(paragraph);
        }

        private void CreateRepositories()
        {
            CreateParagraph("Количество репозиториев: " + ""); //добавить количество


            var paragraph = (HTMLParagraphElement)Document.CreateElement("p");
            var data = "Дата и время прогона антиплагиата: " + DateTime.UtcNow;
            var text = Document.CreateTextNode(data);
            paragraph.AppendChild(text);
            Document.Body.AppendChild(paragraph);
        }
    }
}
