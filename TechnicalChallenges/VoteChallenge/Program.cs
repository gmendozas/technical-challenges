using System;
using System.Linq;

namespace VoteChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a city:");
            var city = Console.ReadLine();
            Console.WriteLine("Enter an estimated cost");
            var estimatedCost = Console.ReadLine();
            Console.WriteLine("Getting the number of votes...");
            Console.WriteLine($"{GetCityVotes(city, estimatedCost)}");

        }

        private static int GetCityVotes(string cityName, string estimatedCost)
        {
            var apiInstance = new VoteApi();
            var result = apiInstance.GetVotesAsync(cityName, estimatedCost).GetAwaiter().GetResult();
            
            if(result != null && result?.Total > 0)
            {
                return result.Data.Sum(s => s.Rating.Votes);
            }
            else
            {
                return 0;
            }

        }
    }
}
