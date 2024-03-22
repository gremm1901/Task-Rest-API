namespace AutotestAPI
{
    public class FilmsResponse
    {
        [JsonPropertyName("title")]
        public string title { get; set; }

        [JsonPropertyName("episode_id")]
        public int episode_id { get; set; }

        [JsonPropertyName("opening_crawl")]
        public string opening_crawl { get; set; }

        [JsonPropertyName("director")]
        public string director { get; set; }

        [JsonPropertyName("producer")]
        public string producer { get; set; }

        [JsonPropertyName("release_date")]
        public string release_date { get; set; }

        [JsonPropertyName("characters")]
        public List<string> characters { get; set; }

        [JsonPropertyName("planets")]
        public List<string> planets { get; set; }

        [JsonPropertyName("starships")]
        public List<string> starships { get; set; }

        [JsonPropertyName("vehicles")]
        public List<string> vehicles { get; set; }

        [JsonPropertyName("species")]
        public List<string> species { get; set; }

        [JsonPropertyName("created")]
        public DateTime created { get; set; }

        [JsonPropertyName("edited")]
        public DateTime edited { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }
    }
}
