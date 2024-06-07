namespace AutotestAPI.Entities.Megaplan.Responses
{
    public class Category165CustomFieldFaylResponse
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
        public int Size { get; set; }

        [JsonPropertyName("subject")]
        public SubjectResponse Subject { get; set; }

        [JsonPropertyName("timeCreated")]
        public TimeCreatedResponse TimeCreated { get; set; }

        [JsonPropertyName("path")]
        public string Path { get; set; }

        [JsonPropertyName("possibleActions")]
        public List<string> PossibleActions { get; set; }

        [JsonPropertyName("metadata")]
        public object Metadata { get; set; }
    }
}
