using HtmlBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitChecker
{
    public class GitCheckerHtml
    {
        public static bool GenerateHTML(List<string> repoLinks, List<List<string>> matchMatrix)
        {
            HtmlGenerator htmlGenerator = new HtmlGenerator();

            htmlGenerator.CreateHeader("h2", "Gitchecker");
            htmlGenerator.CreateHeader("h3", "Дата и время");
            htmlGenerator.CreateDatetime();
            htmlGenerator.CreateHeader("h3", "Репозитории");
            htmlGenerator.CreateList(repoLinks);
            htmlGenerator.CreateHeader("h3", "Результаты проверки репозиториев");
            htmlGenerator.CreateTable(matchMatrix);

            htmlGenerator.Save();

            return true;
        }
    }
}
