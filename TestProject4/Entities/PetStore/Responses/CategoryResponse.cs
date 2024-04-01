namespace AutotestAPI.Entities.PetStore.Responses
{
    public class CategoryResponse
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
