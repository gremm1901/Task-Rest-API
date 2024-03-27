namespace AutotestAPI
{
    public class IsAvailableUserRequest
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("email")]
        public string Email { get; set; }
    }
}
