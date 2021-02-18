using System;
using Octokit;
using System.Threading.Tasks;
using System.Linq;

namespace Walle.GitHubCleaner
{
    class Program
    {
        static void Main(string[] args)
        {
        init:
            try
            {

                Console.WriteLine("Put in your PAT:");
                var pat = Console.ReadLine();
                var conn = new Connection(new ProductHeaderValue("Walle.GitHubCleaner", "v0.1"));
                conn.Credentials = new Credentials(pat);
                var api = new ApiConnection(conn);
                var client = new RepositoriesClient(api);
            listid:
                Console.WriteLine("Listing Repositories...");
                var repositories = client.GetAllForCurrent().Result;
                foreach (var _repos in repositories.OrderByDescending(p => p.CreatedAt))
                {
                    Console.WriteLine($"\t{_repos.Id}\t{_repos.FullName}({_repos.CreatedAt.ToLocalTime():yyyy-MM-dd HH:mm})");
                }
                Console.Write("Input target repository id to delete:");
                var id = Console.ReadLine().Trim();
                if (!repositories.Where(repos => repos.Id.ToString() == id).Any())
                {
                    Console.WriteLine("Invalid Id.(repository not available)");
                    goto listid;
                }
                if (!long.TryParse(id, out long repositoryId))
                {
                    Console.WriteLine("Invalid Id.");
                    goto listid;
                }
                Console.WriteLine("Fetching detail..");
                try
                {
                    var repos = client.Get(repositoryId).Result;
                    Console.WriteLine($"\t{repos.Name}");
                    Console.WriteLine($"\t{repos.FullName}");
                    Console.WriteLine($"\t{repos.HtmlUrl}");
                    Console.WriteLine($"\t{repos.SshUrl}");
                    Console.WriteLine($"\t{repos.Description}");
                    Console.WriteLine($"Delete {repos.Name} ?[Y/n]");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    goto listid;
                }
                if ((new string[] { "yes", "y", "" }).Contains(Console.ReadLine().Trim().ToLower()))
                {
                    client.Delete(repositoryId);
                    id = "";
                    Console.WriteLine("Repository Deleted.");
                }
                else
                {
                    Console.WriteLine("Delete canceled.");
                    id = "";
                }
                goto listid;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto init;
            }
        }
    }
}
