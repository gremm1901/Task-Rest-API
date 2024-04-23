namespace AutotestAPI.Entities.Megaplan.Requests
{
    public class AuditorRequest
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }
    }
}
