namespace AutotestAPI
{
    public class AllPeopleResponse
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
