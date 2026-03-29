using System.Linq;
namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var games = new List<string>()
                { "Halo", "Call of Duty", "Need for Speed", "Red Dead Redemption", "Grand Theft Auto" };

            var gamesDescending = games.OrderByDescending(x => x.Length).ToList();
            foreach (var game in gamesDescending)
            {
                Console.WriteLine(game);
            }
        }
    }
}
