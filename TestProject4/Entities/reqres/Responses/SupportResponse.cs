namespace AutotestAPI.Entities.reqres.Responses
{
    public class SupportResponse
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}