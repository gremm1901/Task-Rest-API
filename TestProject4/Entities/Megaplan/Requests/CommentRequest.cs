namespace AutotestAPI.Entities.Megaplan.Requests
{
    public class CommentRequest
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("content")]
        public string Content { get; set; }

        [JsonPropertyName("attaches")]
        public List<AttachRequest> Attaches { get; set; }

        [JsonPropertyName("workTime")]
        public WorkTimeRequest WorkTime { get; set; }

        [JsonPropertyName("workDate")]
        public WorkDateRequest WorkDate { get; set; }

        [JsonPropertyName("completed")]
        public int Completed { get; set; }

        [JsonPropertyName("owner")]
        public OwnerRequest Owner { get; set; }

        [JsonPropertyName("subject")]
        public SubjectRequest Subject { get; set; }

        [JsonPropertyName("timeCreated")]
        public TimeCreatedRequest TimeCreated { get; set; }
    }
}
