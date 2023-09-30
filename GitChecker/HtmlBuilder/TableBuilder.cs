namespace HtmlBuilder
{
    public class TableBuilder
    {
        public string CreateTable(List<string> colNames, List<string> rowNames, List<List<string>> matrix)
        {
            var htmlTable = "<table style=\"border-collapse: collapse;\"><tbody><tr><th scope=\"col\">repo num</th>";
            htmlTable += CreateColumns(colNames);

            var i = 0;
            foreach (var row in matrix)
            {
                htmlTable += CreateRow(rowNames[i++], row);
            }
            htmlTable += "</tbody></table>";

            return htmlTable;
        }

        public string CreateColumns(List<string> colNames)
        {
            string result = "";
            foreach (var col in colNames)
            {
                result += $"<th scope=\"col\" style=\"border: 1px solid black;\">{col}</th>";
            }
            result += "</tr>";
            return result;
        }

        private string CreateRow(string rowName, List<string> row)
        {
            var result = $"<tr><th scope=\"row\" style=\"border: 1px solid black;\">{rowName}</th>";
            foreach (var item in row)
            {
                result += $"<td style=\"border: 1px solid black;\">{item}</td>";
            }
            result += "</tr>";
            return result;
        }
    }
}