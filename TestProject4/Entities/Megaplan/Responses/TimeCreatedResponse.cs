namespace AutotestAPI.Entities.Megaplan.Responses
{
    public class TimeCreatedResponse
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("value")]
        public DateTime Value { get; set; }
    }
}
