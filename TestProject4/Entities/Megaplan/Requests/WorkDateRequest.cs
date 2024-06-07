namespace AutotestAPI.Entities.Megaplan.Requests
{
    public class WorkDateRequest
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("value")]
        public DateTime Value { get; set; }
    }
}
