namespace AutotestAPI
{
    public class PetPSResponse : AnswerPSResponse
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("category")]
        public CategoryPSResponse Category { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("photoUrls")]
        public List<string> PhotoUrls { get; set; }

        [JsonPropertyName("tags")]
        public List<TagPetPSResponse> Tags { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
