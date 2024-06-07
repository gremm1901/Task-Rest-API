namespace AutotestAPI.Entities.Megaplan.Responses
{
    public class ResponsibleRightsResponse
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("readShort")]
        public bool ReadShort { get; set; }
    }
}
