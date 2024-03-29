﻿namespace AutotestAPI
{
    public class ResourceListDataResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("year")]
        public int Year { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("pantone_value")]
        public string PantoneValue { get; set; }
    }
}