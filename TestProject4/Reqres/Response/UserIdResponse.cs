namespace TestProject4
{
    public class UserIdResponse
    {
        [JsonProperty("data")]
        public UserDataResponse Data { get; set; }

        [JsonProperty("support")]
        public SupportResponse Support { get; set; }
    }
}
