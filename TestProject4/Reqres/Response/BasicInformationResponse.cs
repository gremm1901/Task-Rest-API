﻿namespace AutotestAPI
{
    public class BasicInformationResponse
    {
        [JsonPropertyName("page")]
        public int Page { get; set; }

        [JsonPropertyName("per_page")]
        public int PerPage { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }

        [JsonPropertyName("data")]
        public List<UserDataResponse> Data { get; set; }

        [JsonPropertyName("support")]
        public SupportResponse Support { get; set; }
    }

}