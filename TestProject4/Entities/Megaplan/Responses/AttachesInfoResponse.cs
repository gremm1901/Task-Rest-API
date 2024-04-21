namespace AutotestAPI.Entities.Megaplan.Responses
{
    public class AttachesInfoResponse
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("imageFiles")]
        public List<object> ImageFiles { get; set; }

        [JsonPropertyName("imageFilesCount")]
        public int ImageFilesCount { get; set; }

        [JsonPropertyName("audioFiles")]
        public List<object> AudioFiles { get; set; }

        [JsonPropertyName("audioFilesCount")]
        public int AudioFilesCount { get; set; }

        [JsonPropertyName("otherFiles")]
        public List<object> OtherFiles { get; set; }

        [JsonPropertyName("otherFilesCount")]
        public int OtherFilesCount { get; set; }
    }
}
