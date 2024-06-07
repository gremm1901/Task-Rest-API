namespace AutotestAPI.Entities.Megaplan.Responses
{
    public class SubjectResponse
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("attaches")]
        public List<object> Attaches { get; set; }

        [JsonPropertyName("attachesCount")]
        public int AttachesCount { get; set; }

        [JsonPropertyName("linksCount")]
        public int LinksCount { get; set; }

        [JsonPropertyName("messagesCount")]
        public int MessagesCount { get; set; }

        [JsonPropertyName("attachesCountInComments")]
        public int AttachesCountInComments { get; set; }

        [JsonPropertyName("commentsWithoutTransportCount")]
        public int CommentsWithoutTransportCount { get; set; }

        [JsonPropertyName("emailsCount")]
        public int EmailsCount { get; set; }

        [JsonPropertyName("whatsappCount")]
        public int WhatsappCount { get; set; }

        [JsonPropertyName("telegramCount")]
        public int TelegramCount { get; set; }

        [JsonPropertyName("instagramCount")]
        public int InstagramCount { get; set; }

        [JsonPropertyName("allFiles")]
        public List<AllFileResponse> AllFiles { get; set; }

        [JsonPropertyName("allFilesCount")]
        public int AllFilesCount { get; set; }

        [JsonPropertyName("attachesInfo")]
        public AttachesInfoResponse AttachesInfo { get; set; }

        [JsonPropertyName("hiddenCommentsCount")]
        public int HiddenCommentsCount { get; set; }
    }
}
