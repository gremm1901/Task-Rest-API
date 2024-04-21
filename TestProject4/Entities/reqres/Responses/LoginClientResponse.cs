namespace AutotestAPI.Entities.reqres.Responses
{
    public class LoginClientResponse
    {
        [JsonPropertyName("token")]
        public string Token { get; set; }
    }
}