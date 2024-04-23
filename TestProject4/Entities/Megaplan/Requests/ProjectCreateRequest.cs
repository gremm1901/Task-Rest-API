namespace AutotestAPI.Entities.Megaplan.Requests
{

    public class ProjectCreateRequest
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("deadline")]
        public DeadlineRequest Deadline { get; set; }

        [JsonPropertyName("parent")]
        public ParentRequest Parent { get; set; }

        [JsonPropertyName("isTemplate")]
        public bool IsTemplate { get; set; }

        [JsonPropertyName("owner")]
        public OwnerRequest Owner { get; set; }

        [JsonPropertyName("responsible")]
        public ResponsibleRequest Responsible { get; set; }

        [JsonPropertyName("contractor")]
        public ContractorRequest Contractor { get; set; }

        [JsonPropertyName("attaches")]
        public List<AttachRequest> Attaches { get; set; }

        [JsonPropertyName("statement")]
        public string Statement { get; set; }

        [JsonPropertyName("auditors")]
        public List<AuditorRequest> Auditors { get; set; }

        [JsonPropertyName("kpiUnit")]
        public string KpiUnit { get; set; }

        [JsonPropertyName("kpiStart")]
        public int KpiStart { get; set; }

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
