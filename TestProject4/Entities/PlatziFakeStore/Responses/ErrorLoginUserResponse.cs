namespace AutotestAPI.Entities.PlatziFakeStore.Responses
{
    public class ErrorLoginUserResponse
    {
        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("statusCode")]
        public int StatusCode { get; set; }
    }
}
