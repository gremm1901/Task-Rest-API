namespace TestProject4
{
    public class RegisterClientResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }
    }
}
