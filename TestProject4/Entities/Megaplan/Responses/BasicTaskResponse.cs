namespace AutotestAPI.Entities.Megaplan.Responses
{
    public class BasicTaskResponse
    {
        [JsonPropertyName("meta")]
        public MetaResponse Meta { get; set; }

        [JsonPropertyName("data")]
        public TaskResponse Data { get; set; }
    }
}
