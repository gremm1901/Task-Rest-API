namespace AutotestAPI.Entities.Megaplan.Responses
{
    public class LastOnlineResponse
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("value")]
        public DateTime Value { get; set; }
    }
}
