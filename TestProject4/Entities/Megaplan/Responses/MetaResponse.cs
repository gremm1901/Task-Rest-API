namespace AutotestAPI.Entities.Megaplan.Responses
{
    public class MetaResponse
    {
        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("errors")]
        public List<object> Errors { get; set; }

        [JsonPropertyName("pagination")]
        public List<object> Pagination { get; set; }
    }
}
