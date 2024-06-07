namespace AutotestAPI.Entities.Megaplan.Responses
{
    public class DatumResponse
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("entity")]
        public EntityResponse Entity { get; set; }

        [JsonPropertyName("isSucceed")]
        public bool IsSucceed { get; set; }
    }
}
