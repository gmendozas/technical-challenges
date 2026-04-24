using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using VoteChallenge.Entities;

namespace VoteChallenge
{
    public class VoteApi
    {
        public async Task<Response> GetVotesAsync(string cityName, string estimatedCost)
        {
            try
            {
                using var client = new HttpClient();
                var url = $"https://jsonmock.hackerrank.com/api/food_outlets?city={cityName}&estimated_cost={estimatedCost}";

                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    return JsonSerializer.Deserialize<Response>(responseContent);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}