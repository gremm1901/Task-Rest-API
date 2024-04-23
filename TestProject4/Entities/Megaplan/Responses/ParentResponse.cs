namespace AutotestAPI.Entities.Megaplan.Responses
{
    public class ParentResponse
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("humanNumber")]
        public int HumanNumber { get; set; }

        [JsonPropertyName("owner")]
        public OwnerResponse Owner { get; set; }

        [JsonPropertyName("responsible")]
        public ResponsibleResponse Responsible { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("isTemplate")]
        public bool IsTemplate { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("deadline")]
        public object Deadline { get; set; }

        [JsonPropertyName("isOverdue")]
        public bool IsOverdue { get; set; }

        [JsonPropertyName("rights")]
        public RightsResponse Rights { get; set; }

        [JsonPropertyName("unreadCommentsCount")]
        public int UnreadCommentsCount { get; set; }

        [JsonPropertyName("isFavorite")]
        public bool IsFavorite { get; set; }

        [JsonPropertyName("tags")]
        public List<object> Tags { get; set; }

        [JsonPropertyName("tagsCount")]
        public int TagsCount { get; set; }
    }
}
