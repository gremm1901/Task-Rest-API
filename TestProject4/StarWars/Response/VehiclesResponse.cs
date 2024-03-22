namespace AutotestAPI
{
    public class VehiclesResponse
    {
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("model")]
        public string model { get; set; }

        [JsonPropertyName("manufacturer")]
        public string manufacturer { get; set; }

        [JsonPropertyName("cost_in_credits")]
        public string cost_in_credits { get; set; }

        [JsonPropertyName("length")]
        public string length { get; set; }

        [JsonPropertyName("max_atmosphering_speed")]
        public string max_atmosphering_speed { get; set; }

        [JsonPropertyName("crew")]
        public string crew { get; set; }

        [JsonPropertyName("passengers")]
        public string passengers { get; set; }

        [JsonPropertyName("cargo_capacity")]
        public string cargo_capacity { get; set; }

        [JsonPropertyName("consumables")]
        public string consumables { get; set; }

        [JsonPropertyName("vehicle_class")]
        public string vehicle_class { get; set; }

        [JsonPropertyName("pilots")]
        public List<string> pilots { get; set; }

        [JsonPropertyName("films")]
        public List<string> films { get; set; }

        [JsonPropertyName("created")]
        public DateTime created { get; set; }

        [JsonPropertyName("edited")]
        public DateTime edited { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }
    }
}
