namespace AutotestAPI.Entities.Megaplan.Responses
{
    public class ComentResponse
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("content")]
        public string Content { get; set; }

        [JsonPropertyName("isDropped")]
        public bool IsDropped { get; set; }

        [JsonPropertyName("subject")]
        public SubjectResponse Subject { get; set; }

        [JsonPropertyName("owner")]
        public OwnerResponse Owner { get; set; }

        [JsonPropertyName("attaches")]
        public List<AttachResponse> Attaches { get; set; }

        [JsonPropertyName("attachesCount")]
        public int AttachesCount { get; set; }

        [JsonPropertyName("timeCreated")]
        public TimeCreatedResponse TimeCreated { get; set; }

        [JsonPropertyName("timeUpdated")]
        public TimeUpdatedResponse TimeUpdated { get; set; }

        [JsonPropertyName("relationLinks")]
        public List<object> RelationLinks { get; set; }

        [JsonPropertyName("relationLinksCount")]
        public int RelationLinksCount { get; set; }

        [JsonPropertyName("workTime")]
        public WorkTimeResponse WorkTime { get; set; }

        [JsonPropertyName("workDate")]
        public WorkDateResponse WorkDate { get; set; }

        [JsonPropertyName("isUnread")]
        public bool IsUnread { get; set; }

        [JsonPropertyName("possibleActions")]
        public List<string> PossibleActions { get; set; }

        [JsonPropertyName("transportMessages")]
        public List<object> TransportMessages { get; set; }

        [JsonPropertyName("transportMessagesCount")]
        public int TransportMessagesCount { get; set; }

        [JsonPropertyName("isFavorite")]
        public bool IsFavorite { get; set; }

        [JsonPropertyName("originalComment")]
        public object OriginalComment { get; set; }

        [JsonPropertyName("isHidden")]
        public bool IsHidden { get; set; }

        [JsonPropertyName("isLiked")]
        public bool IsLiked { get; set; }

        [JsonPropertyName("likes")]
        public List<object> Likes { get; set; }

        [JsonPropertyName("likesCount")]
        public int LikesCount { get; set; }

        [JsonPropertyName("answersCount")]
        public int AnswersCount { get; set; }

        [JsonPropertyName("interactionsCounters")]
        public List<InteractionsCounterResponse> InteractionsCounters { get; set; }

        [JsonPropertyName("forwardFrom")]
        public object ForwardFrom { get; set; }
    }
}
