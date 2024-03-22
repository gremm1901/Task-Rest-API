namespace AutotestAPI
{
    public class AllStarshipsResponse
    {
        [JsonPropertyName("count")]
        public int count { get; set; }

        [JsonPropertyName("next")]
        public string next { get; set; }

        [JsonPropertyName("previous")]
        public object previous { get; set; }

        [JsonPropertyName("results")]
        public List<PeopleResponse> results { get; set; }
    }
}
