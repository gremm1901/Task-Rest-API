namespace AutotestAPI
{
    public class LoginUserPFSRequest
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}
