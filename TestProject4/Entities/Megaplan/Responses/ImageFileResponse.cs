namespace AutotestAPI.Entities.Megaplan.Responses
{
    public class ImageFileResponse
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
