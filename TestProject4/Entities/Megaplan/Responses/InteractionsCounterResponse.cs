namespace AutotestAPI.Entities.Megaplan.Responses
{
    public class InteractionsCounterResponse
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("action")]
        public string Action { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }
    }
}
