namespace AutotestAPI.Entities.StarWars.Responses
{
    public class AllFilmsResponse
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("next")]
        public object Next { get; set; }

        [JsonPropertyName("previous")]
        public object Previous { get; set; }

        [JsonPropertyName("results")]
        public List<FilmsResponse> Results { get; set; }
    }
}
