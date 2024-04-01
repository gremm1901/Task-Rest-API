namespace AutotestAPI.Entities.PlatziFakeStore.Responses
{
    public class AnswerResponse
    {
        [JsonPropertyName("message")]
        public List<string> Message { get; set; }

        [JsonPropertyName("error")]
        public string Error { get; set; }

        [JsonPropertyName("statusCode")]
        public int StatusCode { get; set; }
    }
}
