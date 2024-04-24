﻿namespace AutotestAPI.Entities.Megaplan.Requests
{
    public class ContractorRequest
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }
    }

}