namespace AutotestAPI
{
    public class AllSpeciesResponse
    {
        [JsonPropertyName("count")]
        public int count { get; set; }

        [JsonPropertyName("next")]
        public string next { get; set; }

        [JsonPropertyName("previous")]
        public object previous { get; set; }

        [JsonPropertyName("results")]
        public List<SpeciesResponse> results { get; set; }
    }
}
