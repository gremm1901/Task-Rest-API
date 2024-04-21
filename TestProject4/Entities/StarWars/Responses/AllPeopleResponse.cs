namespace AutotestAPI.Entities.StarWars.Responses
{
    public class AllPeopleResponse
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("next")]
        public string Next { get; set; }

        [JsonPropertyName("previous")]
        public object Previous { get; set; }

        [JsonPropertyName("results")]
        public List<PeopleResponse> Results { get; set; }
    }
}
