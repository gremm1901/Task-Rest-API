namespace AutotestAPI.Entities.Megaplan.Requests
{
    public class CreateCommentRequest
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("comment")]
        public CommentRequest Comment { get; set; }

        [JsonPropertyName("transports")]
        public List<TransportRequest> Transports { get; set; }
    }
}
