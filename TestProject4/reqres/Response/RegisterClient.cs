namespace TestProject4
{
    public class RegisterClient
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }
    }
}
