namespace AutotestAPI.Entities.Megaplan.Requests
{

    public class ProjectCreateRequest
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("id")]
        public string Id  { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("deadline")]
        public DeadlineRequest Deadline { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("parent")]
        public ParentRequest Parent { get; set; }

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
        public ContractorRequest Contractor { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("attaches")]
        public List<AttachRequest> Attaches { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("statement")]
        public string Statement { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("auditors")]
        public List<AuditorRequest> Auditors { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("kpiUnit")]
        public string KpiUnit { get; set; }

        [JsonPropertyName("kpiStart")]
        public int KpiStart { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("executors")]
        public List<ExecutorRequest> Executors { get; set; }

        [JsonPropertyName("Category165CustomFieldChislo")]
        public int Category165CustomFieldChislo { get; set; }

        [JsonPropertyName("Category165CustomFieldViborIzSpiska")]
        public string Category165CustomFieldViborIzSpiska { get; set; }

        [JsonPropertyName("Category165CustomFieldDaNet")]
        public bool Category165CustomFieldDaNet { get; set; }

        [JsonPropertyName("Category165CustomFieldDataIVremya")]
        public Category165CustomFieldDataIVremyaRequest Category165CustomFieldDataIVremya { get; set; }

        [JsonPropertyName("Category165CustomFieldBolshoeChislo")]
        public string Category165CustomFieldBolshoeChislo { get; set; }

        [JsonPropertyName("Category165CustomFieldSotrudnikKlient")]
        public Category165CustomFieldSotrudnikKlientRequest Category165CustomFieldSotrudnikKlient { get; set; }

        [JsonPropertyName("Category165CustomFieldFayl")]
        public List<Category165CustomFieldFaylRequest> Category165CustomFieldFayl { get; set; }

        [JsonPropertyName("Category165CustomFieldPlanFakt")]
        public Category165CustomFieldPlanFaktRequest Category165CustomFieldPlanFakt { get; set; }
    }

}
