namespace TestProject4
{
        public class CreateClientRequest
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("job")]
            public string Job { get; set; }
        }
}
