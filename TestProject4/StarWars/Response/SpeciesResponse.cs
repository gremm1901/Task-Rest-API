namespace AutotestAPI
{
    public class SpeciesResponse
    {
        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("classification")]
        public string classification { get; set; }

        [JsonPropertyName("designation")]
        public string designation { get; set; }

        [JsonPropertyName("average_height")]
        public string average_height { get; set; }

        [JsonPropertyName("skin_colors")]
        public string skin_colors { get; set; }

        [JsonPropertyName("hair_colors")]
        public string hair_colors { get; set; }

        [JsonPropertyName("eye_colors")]
        public string eye_colors { get; set; }

        [JsonPropertyName("average_lifespan")]
        public string average_lifespan { get; set; }

        [JsonPropertyName("homeworld")]
        public string homeworld { get; set; }

        [JsonPropertyName("language")]
        public string language { get; set; }

        [JsonPropertyName("people")]
        public List<string> people { get; set; }

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
