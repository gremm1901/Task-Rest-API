namespace AutotestAPI.Entities.Megaplan.Requests
{
    public class AuthEmployeeRequest
    {
        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonPropertyName("grant_type")]
        public string GrantType { get; set; }
    }
}
