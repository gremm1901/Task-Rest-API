namespace AutotestAPI
{
    public class AnswerPSResponse
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
