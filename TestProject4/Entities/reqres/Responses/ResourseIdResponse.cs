namespace AutotestAPI.Entities.reqres.Responses
{
    public class ResourseIdResponse
    {
        [JsonPropertyName("data")]
        public ResourceListDataResponse Data { get; set; }

        [JsonPropertyName("support")]
        public SupportResponse Support { get; set; }
    }
}