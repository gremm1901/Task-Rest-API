namespace AutotestAPI
{
    public class UserIdResponse
    {
        [JsonPropertyName("data")]
        public UserDataResponse Data { get; set; }

        [JsonPropertyName("support")]
        public SupportResponse Support { get; set; }
    }
}