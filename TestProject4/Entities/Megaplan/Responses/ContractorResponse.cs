namespace AutotestAPI.Entities.Megaplan.Responses
{
    public class ContractorResponse
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("humanNumber")]
        public long HumanNumber { get; set; }

        [JsonPropertyName("type")]
        public TypeResponse Type { get; set; }

        [JsonPropertyName("responsibles")]
        public List<ResponsiblesResponse> Responsibles { get; set; }

        [JsonPropertyName("responsiblesCount")]
        public int ResponsiblesCount { get; set; }

        [JsonPropertyName("canSeeFull")]
        public bool CanSeeFull { get; set; }

        [JsonPropertyName("possibleActions")]
        public List<string> PossibleActions { get; set; }

        [JsonPropertyName("contactInfo")]
        public List<object> ContactInfo { get; set; }

        [JsonPropertyName("contactInfoCount")]
        public int ContactInfoCount { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("textDescription")]
        public string TextDescription { get; set; }

        [JsonPropertyName("birthday")]
        public object Birthday { get; set; }

        [JsonPropertyName("preferTransport")]
        public string PreferTransport { get; set; }

        [JsonPropertyName("status")]
        public object Status { get; set; }

        [JsonPropertyName("isDropped")]
        public bool IsDropped { get; set; }

        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("middleName")]
        public string MiddleName { get; set; }

        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        [JsonPropertyName("dateLastReadNews")]
        public object DateLastReadNews { get; set; }

        [JsonPropertyName("company")]
        public object Company { get; set; }

        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("position")]
        public string Position { get; set; }

        [JsonPropertyName("loginEmail")]
        public object LoginEmail { get; set; }

        [JsonPropertyName("lastOnline")]
        public object LastOnline { get; set; }

        [JsonPropertyName("canLogin")]
        public bool CanLogin { get; set; }

        [JsonPropertyName("isGuestAccessEnabled")]
        public bool IsGuestAccessEnabled { get; set; }

        [JsonPropertyName("avatar")]
        public object Avatar { get; set; }

        [JsonPropertyName("isFavorite")]
        public bool IsFavorite { get; set; }

        [JsonPropertyName("tags")]
        public List<object> Tags { get; set; }

        [JsonPropertyName("tagsCount")]
        public int TagsCount { get; set; }

        [JsonPropertyName("commentsCount")]
        public int CommentsCount { get; set; }

        [JsonPropertyName("unreadCommentsCount")]
        public int UnreadCommentsCount { get; set; }

        [JsonPropertyName("subscribed")]
        public bool Subscribed { get; set; }
    }
}
