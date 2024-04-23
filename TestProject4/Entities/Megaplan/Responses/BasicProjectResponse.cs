

namespace AutotestAPI.Entities.Megaplan.Responses
{
    public class BasicProjectResponse
    {
        [JsonPropertyName("meta")]
        public MetaResponse Meta { get; set; }

        [JsonPropertyName("data")]
        public ProjectResponse Data { get; set; }
    }
}
