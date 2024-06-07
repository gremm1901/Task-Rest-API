namespace AutotestAPI.Entities.Megaplan.Responses
{
    public class EntityResponse
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
