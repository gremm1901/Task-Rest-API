namespace AutotestAPI
{
    public class ErrorLoginUserResponse
    {
        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("statusCode")]
        public int StatusCode { get; set; }
    }
}
