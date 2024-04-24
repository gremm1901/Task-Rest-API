namespace AutotestAPI.Entities.Megaplan.Responses
{
    public class MassDeleteResponse
    {
        [JsonPropertyName("meta")]
        public MetaResponse Meta { get; set; }

        [JsonPropertyName("data")]
        public List<DatumResponse> Data { get; set; }
    }
}
