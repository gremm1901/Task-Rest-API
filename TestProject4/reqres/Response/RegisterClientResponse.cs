namespace AutotestAPI
{
    public class RegisterClientResponse
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("token")]
        public string Token { get; set; }
    }
}