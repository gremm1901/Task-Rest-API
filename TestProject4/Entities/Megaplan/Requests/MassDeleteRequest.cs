namespace AutotestAPI.Entities.Megaplan.Requests
{
    public class MassDeleteRequest
    {
        [JsonPropertyName("entities")]
        public List<EntityDeleteRequest> Entities { get; set; }

        [JsonPropertyName("withNotifications")]
        public bool WithNotifications { get; set; }

        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }
    }
}
