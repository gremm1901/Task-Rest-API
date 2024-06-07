namespace AutotestAPI.Entities.Megaplan.Requests
{
    public class TaskCreateRequest
    {
        
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("deadline")]
        public object Deadline { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("parent")]
        public ParentRequest Parent { get; set; }

        [JsonPropertyName("isUrgent")]
        public bool IsUrgent { get; set; }

        [JsonPropertyName("isTemplate")]
        public bool IsTemplate { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("owner")]
        public OwnerRequest Owner { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("responsible")]
        public ResponsibleRequest Responsible { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("contractor")]
        public object Contractor { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("attaches")]
        public List<object> Attaches { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Category130CustomFieldTipTekst")]
        public object Category130CustomFieldTipTekst { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Category130CustomFieldTipTekstBezFormatirovaniya")]
        public object Category130CustomFieldTipTekstBezFormatirovaniya { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Category130CustomFieldTipChislo")]
        public object Category130CustomFieldTipChislo { get; set; }

        [JsonPropertyName("Category130CustomFieldTipDaNet")]
        public bool Category130CustomFieldTipDaNet { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Category130CustomFieldTipBolshoeChislo")]
        public object Category130CustomFieldTipBolshoeChislo { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Category130CustomFieldTipVibor")]
        public string Category130CustomFieldTipVibor { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Category130CustomFieldTipUnikalniyTekst")]
        public object Category130CustomFieldTipUnikalniyTekst { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Category130CustomFieldOtsenka1")]
        public object Category130CustomFieldOtsenka1 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Category130CustomFieldOtsenka2")]
        public object Category130CustomFieldOtsenka2 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Category130CustomFieldOtsenka3")]
        public object Category130CustomFieldOtsenka3 { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Category130CustomFieldFayliki")]
        public object Category130CustomFieldFayliki { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Category130CustomFieldPlanFakt")]
        public object Category130CustomFieldPlanFakt { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("executors")]
        public List<ExecutorRequest> Executors { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        [JsonPropertyName("isGroup")]
        public bool IsGroup { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("statement")]
        public string Statement { get; set; }
    }
}
