using HTML_generator;

public class Program
{
    private static void Main(string[] args)
    {
        HtmlGenerator htmlGenerator = new HtmlGenerator();
        var a = new List<string>() { "repo1", "repo2", "repo3" };
        htmlGenerator.GenerateHTML(a, new List<List<string>>() { new List<string>() { "100", "44", "77" }, new List<string>() { "44", "100", "77" }, new List<string>() { "77", "44", "100" } });
    }
}