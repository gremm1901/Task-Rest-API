namespace AutotestAPI.Entities.Megaplan.Responses
{
    public class FileBaseResponse
    {
        [JsonPropertyName("meta")]
        public MetaResponse Meta { get; set; }

        [JsonPropertyName("data")]
        public List<FileResponse> Data { get; set; }
    }
}
