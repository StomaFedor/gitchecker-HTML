using GitChecker;
using System.Linq.Expressions;

public class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Введите количество репозиториев и сами репозитории");
            var num = Convert.ToInt32(Console.ReadLine());
            var repos = new List<string>();
            for (int i = 0; i < num; i++)
            {
                Console.Write((i + 1) + ") ");
                repos.Add(Console.ReadLine());
            }

            Console.WriteLine("Введите процент совпадения репозиториев в виде матрицы");
            var matrix = new List<List<string>>();
            for (int i = 0; i < num; i++)
            {
                Console.Write((i + 1) + ") ");
                matrix.Add(Console.ReadLine().Split().ToList());
            }
            GitCheckerHtml.GenerateHTML(repos, matrix);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
    }
}