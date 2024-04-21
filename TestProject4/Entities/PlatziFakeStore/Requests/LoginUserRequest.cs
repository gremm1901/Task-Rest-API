namespace AutotestAPI.Entities.PlatziFakeStore.Requests
{
    public class LoginUserRequest
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("password")]
        public string Password { get; set; }
    }
}
