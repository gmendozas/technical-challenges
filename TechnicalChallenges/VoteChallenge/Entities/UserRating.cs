using System;
using System.Text.Json.Serialization;

namespace VoteChallenge.Entities
{
    [Serializable]
    public class UserRating
    {
        [JsonPropertyName("average_rating")]
        public decimal AverageRating { get; set; }
        [JsonPropertyName("votes")]
        public int Votes { get; set; }
    }
}
