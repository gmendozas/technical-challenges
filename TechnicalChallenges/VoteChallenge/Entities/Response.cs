using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VoteChallenge.Entities
{
    [Serializable]
    public class Response
    {
        [JsonPropertyName("page")]
        public int Page { get; set; }
        [JsonPropertyName("per_page")]
        public int PerPage { get; set; }
        [JsonPropertyName("total")]
        public int Total { get; set; }
        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }
        [JsonPropertyName("data")]
        public ICollection<Datum> Data { get; set; }
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
