using System;
using System.Text.Json.Serialization;

namespace VoteChallenge.Entities
{
    [Serializable]
    public class Datum
    {
        [JsonPropertyName("city")]
        public string City { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("estimated_cost")]
        public decimal EstimatedCost { get; set; }
        [JsonPropertyName("user_rating")]
        public UserRating Rating { get; set; }
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}