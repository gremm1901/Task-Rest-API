﻿namespace AutotestAPI
{
    public class AllVehiclesResponse
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("next")]
        public string Next { get; set; }

        [JsonPropertyName("previous")]
        public object Previous { get; set; }

        [JsonPropertyName("results")]
        public List<VehiclesResponse> Results { get; set; }
    }
}
