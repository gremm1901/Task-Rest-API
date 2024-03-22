namespace AutotestAPI
{
    public class LoginClientResponse
    {
        [JsonPropertyName("token")]
        public string Token { get; set; }
    }
}