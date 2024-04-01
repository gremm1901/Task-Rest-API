namespace AutotestAPI.Entities.PlatziFakeStore.Requests
{
    public class IsAvailableUserPRequest
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("email")]
        public string Email { get; set; }
    }
}
