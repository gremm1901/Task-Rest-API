namespace AutotestAPI.Entities.PlatziFakeStore.Responses
{
    public class ErrorRespose : AnswerResponse
    {
        [JsonPropertyName("path")]
        public string Path { get; set; }

        [JsonPropertyName("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
