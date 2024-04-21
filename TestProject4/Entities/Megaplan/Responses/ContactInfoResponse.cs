namespace AutotestAPI.Entities.Megaplan.Responses
{
    public class ContactInfoResponse
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("comment")]
        public string Comment { get; set; }

        [JsonPropertyName("isMain")]
        public bool? IsMain { get; set; }

        [JsonPropertyName("subject")]
        public SubjectResponse Subject { get; set; }
    }
}
