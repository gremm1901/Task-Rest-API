namespace AutotestAPI.Entities.Megaplan.Responses
{
    public class ProjectResponse
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("humanNumber")]
        public int HumanNumber { get; set; }

        [JsonPropertyName("owner")]
        public OwnerResponse Owner { get; set; }

        [JsonPropertyName("relationLinks")]
        public List<object> RelationLinks { get; set; }

        [JsonPropertyName("relationLinksCount")]
        public int RelationLinksCount { get; set; }

        [JsonPropertyName("auditors")]
        public List<AuditorResponse> Auditors { get; set; }

        [JsonPropertyName("auditorsCount")]
        public int AuditorsCount { get; set; }

        [JsonPropertyName("subProjects")]
        public List<object> SubProjects { get; set; }

        [JsonPropertyName("tasks")]
        public List<object> Tasks { get; set; }

        [JsonPropertyName("executors")]
        public List<ExecutorResponse> Executors { get; set; }

        [JsonPropertyName("executorsCount")]
        public int ExecutorsCount { get; set; }

        [JsonPropertyName("participants")]
        public List<ParticipantResponse> Participants { get; set; }

        [JsonPropertyName("participantsCount")]
        public int ParticipantsCount { get; set; }

        [JsonPropertyName("attaches")]
        public List<AttachResponse> Attaches { get; set; }

        [JsonPropertyName("attachesCount")]
        public int AttachesCount { get; set; }

        [JsonPropertyName("responsible")]
        public ResponsibleResponse Responsible { get; set; }

        [JsonPropertyName("statement")]
        public string Statement { get; set; }

        [JsonPropertyName("textStatement")]
        public string TextStatement { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("isTemplate")]
        public bool IsTemplate { get; set; }

        [JsonPropertyName("originalTemplate")]
        public object OriginalTemplate { get; set; }

        [JsonPropertyName("isTemplateOwnerCurrentUser")]
        public bool IsTemplateOwnerCurrentUser { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("statusChangeTime")]
        public StatusChangeTimeResponse StatusChangeTime { get; set; }

        [JsonPropertyName("deadline")]
        public DeadlineResponse Deadline { get; set; }

        [JsonPropertyName("deadlineReminders")]
        public List<object> DeadlineReminders { get; set; }

        [JsonPropertyName("deadlineRemindersCount")]
        public int DeadlineRemindersCount { get; set; }

        [JsonPropertyName("isOverdue")]
        public bool IsOverdue { get; set; }

        [JsonPropertyName("activity")]
        public ActivityResponse Activity { get; set; }

        [JsonPropertyName("actualStart")]
        public ActualStartResponse ActualStart { get; set; }

        [JsonPropertyName("actualFinish")]
        public object ActualFinish { get; set; }

        [JsonPropertyName("plannedFinish")]
        public object PlannedFinish { get; set; }

        [JsonPropertyName("duration")]
        public DurationResponse Duration { get; set; }

        [JsonPropertyName("completed")]
        public int Completed { get; set; }

        [JsonPropertyName("responsibleCanEditExtFields")]
        public bool ResponsibleCanEditExtFields { get; set; }

        [JsonPropertyName("executorsCanEditExtFields")]
        public bool ExecutorsCanEditExtFields { get; set; }

        [JsonPropertyName("auditorsCanEditExtFields")]
        public bool AuditorsCanEditExtFields { get; set; }

        [JsonPropertyName("actualWork")]
        public ActualWorkResponse ActualWork { get; set; }

        [JsonPropertyName("rights")]
        public RightsResponse Rights { get; set; }

        [JsonPropertyName("milestones")]
        public List<object> Milestones { get; set; }

        [JsonPropertyName("milestonesCount")]
        public int MilestonesCount { get; set; }

        [JsonPropertyName("deals")]
        public List<object> Deals { get; set; }

        [JsonPropertyName("dealsCount")]
        public int DealsCount { get; set; }

        [JsonPropertyName("actualDealsCount")]
        public int ActualDealsCount { get; set; }

        [JsonPropertyName("linksCount")]
        public int LinksCount { get; set; }

        [JsonPropertyName("deadlineChangeRequest")]
        public object DeadlineChangeRequest { get; set; }

        [JsonPropertyName("contractor")]
        public ContractorResponse Contractor { get; set; }

        [JsonPropertyName("timeCreated")]
        public TimeCreatedResponse TimeCreated { get; set; }

        [JsonPropertyName("plannedWork")]
        public PlannedWorkResponse PlannedWork { get; set; }

        [JsonPropertyName("parents")]
        public List<ParentResponse> Parents { get; set; }

        [JsonPropertyName("parentsCount")]
        public int ParentsCount { get; set; }

        [JsonPropertyName("parent")]
        public ParentResponse Parent { get; set; }

        [JsonPropertyName("issues")]
        public List<object> Issues { get; set; }

        [JsonPropertyName("issuesCount")]
        public int IssuesCount { get; set; }

        [JsonPropertyName("actualIssuesCount")]
        public int ActualIssuesCount { get; set; }

        [JsonPropertyName("entitiesByTemplate")]
        public List<object> EntitiesByTemplate { get; set; }

        [JsonPropertyName("todos")]
        public List<object> Todos { get; set; }

        [JsonPropertyName("todosCount")]
        public int TodosCount { get; set; }

        [JsonPropertyName("messagesCount")]
        public int MessagesCount { get; set; }

        [JsonPropertyName("lastComment")]
        public ComentResponse LastComment { get; set; }

        [JsonPropertyName("lastCommentTimeCreated")]
        public object LastCommentTimeCreated { get; set; }

        [JsonPropertyName("firstUnreadComment")]
        public object FirstUnreadComment { get; set; }

        [JsonPropertyName("reminderTime")]
        public object ReminderTime { get; set; }

        [JsonPropertyName("interactionsCounters")]
        public List<object> InteractionsCounters { get; set; }

        [JsonPropertyName("editableFields")]
        public List<string> EditableFields { get; set; }

        [JsonPropertyName("workedOffTimeTotal")]
        public WorkedOffTimeTotalResponse WorkedOffTimeTotal { get; set; }

        [JsonPropertyName("comments")]
        public List<ComentResponse> Comments { get; set; }

        [JsonPropertyName("commentsCount")]
        public int CommentsCount { get; set; }

        [JsonPropertyName("unreadCommentsCount")]
        public int UnreadCommentsCount { get; set; }

        [JsonPropertyName("attachesCountInComments")]
        public int AttachesCountInComments { get; set; }

        [JsonPropertyName("unreadAnswer")]
        public bool UnreadAnswer { get; set; }

        [JsonPropertyName("subscribed")]
        public bool Subscribed { get; set; }

        [JsonPropertyName("commentsWithoutTransportCount")]
        public int CommentsWithoutTransportCount { get; set; }

        [JsonPropertyName("emailsCount")]
        public int EmailsCount { get; set; }

        [JsonPropertyName("whatsappCount")]
        public int WhatsappCount { get; set; }

        [JsonPropertyName("telegramCount")]
        public int TelegramCount { get; set; }

        [JsonPropertyName("instagramCount")]
        public int InstagramCount { get; set; }

        [JsonPropertyName("Category165CustomFieldChislo")]
        public int Category165CustomFieldChislo { get; set; }

        [JsonPropertyName("Category165CustomFieldViborIzSpiska")]
        public string Category165CustomFieldViborIzSpiska { get; set; }

        [JsonPropertyName("Category165CustomFieldDaNet")]
        public bool Category165CustomFieldDaNet { get; set; }

        [JsonPropertyName("Category165CustomFieldDataIVremya")]
        public Category165CustomFieldDataIVremyaResponse Category165CustomFieldDataIVremya { get; set; }

        [JsonPropertyName("Category165CustomFieldBolshoeChislo")]
        public string Category165CustomFieldBolshoeChislo { get; set; }

        [JsonPropertyName("Category165CustomFieldSotrudnikKlient")]
        public Category165CustomFieldSotrudnikKlientResponse Category165CustomFieldSotrudnikKlient { get; set; }

        [JsonPropertyName("Category165CustomFieldFayl")]
        public List<Category165CustomFieldFaylResponse> Category165CustomFieldFayl { get; set; }

        [JsonPropertyName("Category165CustomFieldPlanFakt")]
        public Category165CustomFieldPlanFaktResponse Category165CustomFieldPlanFakt { get; set; }

        [JsonPropertyName("isFavorite")]
        public bool IsFavorite { get; set; }

        [JsonPropertyName("lastView")]
        public object LastView { get; set; }

        [JsonPropertyName("tags")]
        public List<object> Tags { get; set; }

        [JsonPropertyName("tagsCount")]
        public int TagsCount { get; set; }

        [JsonPropertyName("actualTodosCount")]
        public int ActualTodosCount { get; set; }

        [JsonPropertyName("finishedTodosCount")]
        public int FinishedTodosCount { get; set; }

        [JsonPropertyName("financeOperations")]
        public List<object> FinanceOperations { get; set; }

        [JsonPropertyName("financeOperationsCount")]
        public int FinanceOperationsCount { get; set; }

        [JsonPropertyName("allFiles")]
        public List<AllFileResponse> AllFiles { get; set; }

        [JsonPropertyName("allFilesCount")]
        public int AllFilesCount { get; set; }

        [JsonPropertyName("attachesInfo")]
        public AttachesInfoResponse AttachesInfo { get; set; }

        [JsonPropertyName("hiddenCommentsCount")]
        public int HiddenCommentsCount { get; set; }

        [JsonPropertyName("kpiStart")]
        public int KpiStart { get; set; }

        [JsonPropertyName("kpiPlanned")]
        public object KpiPlanned { get; set; }

        [JsonPropertyName("kpiActual")]
        public object KpiActual { get; set; }

        [JsonPropertyName("kpiUnit")]
        public string KpiUnit { get; set; }

        [JsonPropertyName("kpiPercentage")]
        public int KpiPercentage { get; set; }

        [JsonPropertyName("calculatedFields")]
        public List<object> CalculatedFields { get; set; }

        [JsonPropertyName("calculatedFieldsCount")]
        public int CalculatedFieldsCount { get; set; }
    }
}
