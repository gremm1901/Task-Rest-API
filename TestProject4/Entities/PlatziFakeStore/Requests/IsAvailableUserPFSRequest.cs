namespace AutotestAPI
{
    public class IsAvailableUserPFSRequest
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("email")]
        public string Email { get; set; }
    }
}
