namespace AutotestAPI.Entities.reqres.Responses
{
    public class CreatedClientResponse
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }
    }
}