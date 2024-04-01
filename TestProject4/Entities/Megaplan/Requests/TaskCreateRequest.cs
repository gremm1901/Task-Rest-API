namespace AutotestAPI.Entities.Megaplan.Requests
{
    public class TaskCreateRequest
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("isUrgent")]
        public bool IsUrgent { get; set; }

        [JsonPropertyName("isTemplate")]
        public bool IsTemplate { get; set; }

        [JsonPropertyName("responsible")]
        public ResponsibleRequest Responsible { get; set; }

        [JsonPropertyName("Category130CustomFieldTipDaNet")]
        public bool Category130CustomFieldTipDaNet { get; set; }
    }
}
