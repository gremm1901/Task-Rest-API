namespace AutotestAPI.Entities.Megaplan.Requests
{
    public class TaskCreateRequest
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("isUrgent")]
        public bool IsUrgent { get; set; }

        [JsonPropertyName("isTemplate")]
        public bool IsTemplate { get; set; }

        [JsonPropertyName("responsible")]
        public ResponsibleRequest Responsible { get; set; }
    }
}
