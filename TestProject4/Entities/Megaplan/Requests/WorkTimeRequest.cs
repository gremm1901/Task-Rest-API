namespace AutotestAPI.Entities.Megaplan.Requests
{
    public class WorkTimeRequest
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("value")]
        public int Value { get; set; }
    }
}
