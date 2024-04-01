namespace AutotestAPI.Entities.reqres.Requests
{
    public class CreateClientRequest
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("job")]
        public string Job { get; set; }
    }
}