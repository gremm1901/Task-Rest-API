namespace AutotestAPI.Entities.Megaplan.Responses
{
    public class Category130CustomFieldPlanFaktResponse
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("planned")]
        public int Planned { get; set; }

        [JsonPropertyName("actual")]
        public int Actual { get; set; }
    }
}
