using System;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var carNames = new string[] { "Honda Civic", "Toyota Camry", "Ford Taurus", "Volkswagen Jetta", "Chevy Impala" };
            var carsWithC = from cars in carNames
                            where cars.ToLower().Contains("c")
                            orderby cars descending
                            select cars;
            foreach (var car in carsWithC)
            {
                Console.WriteLine(car);
            }
            var videoGames = new string[] { "Skyrim", "Breath of the Wild", "Doom", "Crusader Kings II", "Dota2" };
            var videoGamesByName = videoGames.OrderBy(game => game.Length);
            foreach (var game in videoGamesByName)
            {
                Console.WriteLine(game);
            }
        }
    }
}
