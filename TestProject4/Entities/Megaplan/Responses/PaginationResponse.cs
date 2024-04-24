namespace AutotestAPI.Entities.Megaplan.Responses
{
    public class PaginationResponse
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }
    }
}
