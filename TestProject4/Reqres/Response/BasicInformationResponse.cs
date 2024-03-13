namespace TestProject4
{
    public class BasicInformationResponse
    {
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("data")]
        public List<UserDataResponse> Data { get; set; }

        [JsonProperty("support")]
        public SupportResponse Support { get; set; }
    }

}