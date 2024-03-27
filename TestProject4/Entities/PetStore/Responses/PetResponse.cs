﻿namespace AutotestAPI
{
    public class PetResponse : AnswerResponse
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("category")]
        public CategoryPetResponse Category { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("photoUrls")]
        public List<string> PhotoUrls { get; set; }

        [JsonPropertyName("tags")]
        public List<TagPetResponse> Tags { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
