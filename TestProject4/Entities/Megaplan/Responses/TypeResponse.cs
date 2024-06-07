namespace AutotestAPI.Entities.Megaplan.Responses
{
    public class TypeResponse
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("fixedFields")]
        public List<object> FixedFields { get; set; }

        [JsonPropertyName("layoutSetting")]
        public object LayoutSetting { get; set; }

        [JsonPropertyName("layoutTabletSetting")]
        public object LayoutTabletSetting { get; set; }

        [JsonPropertyName("rights")]
        public RightsResponse Rights { get; set; }

        [JsonPropertyName("responsibleRights")]
        public ResponsibleRightsResponse ResponsibleRights { get; set; }

        [JsonPropertyName("visibleInCardFields")]
        public List<string> VisibleInCardFields { get; set; }

        [JsonPropertyName("requiredFields")]
        public List<string> RequiredFields { get; set; }

        [JsonPropertyName("visibleOnCreationFields")]
        public List<string> VisibleOnCreationFields { get; set; }
    }
}
