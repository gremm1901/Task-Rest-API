namespace AutotestAPI.Entities.Megaplan.Responses
{
    public class FileResponse
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("mimeType")]
        public string MimeType { get; set; }

        [JsonPropertyName("extension")]
        public string Extension { get; set; }

        [JsonPropertyName("size")]
        public long Size { get; set; }

        [JsonPropertyName("subject")]
        public object Subject { get; set; }

        [JsonPropertyName("timeCreated")]
        public DateTime TimeCreated { get; set; }

        [JsonPropertyName("path")]
        public string Path { get; set; }

        [JsonPropertyName("possibleActions")]
        public List<string> PossibleActions { get; set; }

        [JsonPropertyName("metadata")]
        public object Metadata { get; set; }
    }
}
