namespace AutotestAPI
{
    public class AllFilmsResponse
    {
        [JsonPropertyName("count")]
        public int count { get; set; }

        [JsonPropertyName("next")]
        public object next { get; set; }

        [JsonPropertyName("previous")]
        public object previous { get; set; }

        [JsonPropertyName("results")]
        public List<FilmsResponse> results { get; set; }
    }
}
