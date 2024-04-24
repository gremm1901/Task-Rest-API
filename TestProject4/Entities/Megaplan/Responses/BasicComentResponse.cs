namespace AutotestAPI.Entities.Megaplan.Responses
{
    public class BasicComentResponse
    {
        [JsonPropertyName("meta")]
        public MetaResponse Meta { get; set; }

        [JsonPropertyName("data")]
        public ComentResponse Data { get; set; }
    }
}
