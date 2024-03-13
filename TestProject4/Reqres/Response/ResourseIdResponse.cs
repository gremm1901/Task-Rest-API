namespace TestProject4
{
    public class ResourseIdResponse
    {
        [JsonProperty("data")]
        public ResourceListDataResponse Data { get; set; }

        [JsonProperty("support")]
        public SupportResponse Support { get; set; }
    }
}
