using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AutotestAPI.Entities.Megaplan.Responses
{
    public class TaskResponse
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("humanNumber")]
        public int HumanNumber { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("isOverdue")]
        public bool IsOverdue { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("statusChangeTime")]
        public StatusChangeTime StatusChangeTime { get; set; }

        [JsonPropertyName("owner")]
        public Owner Owner { get; set; }

        [JsonPropertyName("isTemplateOwnerCurrentUser")]
        public bool IsTemplateOwnerCurrentUser { get; set; }

        [JsonPropertyName("deadline")]
        public object Deadline { get; set; }

        [JsonPropertyName("subTasks")]
        public List<object> SubTasks { get; set; }

        [JsonPropertyName("subTasksCount")]
        public int SubTasksCount { get; set; }

        [JsonPropertyName("actualSubTasksCount")]
        public int ActualSubTasksCount { get; set; }

        [JsonPropertyName("responsible")]
        public Responsible Responsible { get; set; }

        [JsonPropertyName("completed")]
        public int Completed { get; set; }

        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        [JsonPropertyName("isUrgent")]
        public bool IsUrgent { get; set; }

        [JsonPropertyName("isNegotiation")]
        public bool IsNegotiation { get; set; }

        [JsonPropertyName("auditors")]
        public List<object> Auditors { get; set; }

        [JsonPropertyName("auditorsCount")]
        public int AuditorsCount { get; set; }

        [JsonPropertyName("executors")]
        public List<object> Executors { get; set; }

        [JsonPropertyName("executorsCount")]
        public int ExecutorsCount { get; set; }

        [JsonPropertyName("isTemplate")]
        public bool IsTemplate { get; set; }

        [JsonPropertyName("originalTemplate")]
        public object OriginalTemplate { get; set; }

        [JsonPropertyName("schedule")]
        public object Schedule { get; set; }

        [JsonPropertyName("attaches")]
        public List<object> Attaches { get; set; }

        [JsonPropertyName("attachesCount")]
        public int AttachesCount { get; set; }

        [JsonPropertyName("actualStart")]
        public ActualStart ActualStart { get; set; }

        [JsonPropertyName("plannedWork")]
        public PlannedWork PlannedWork { get; set; }

        [JsonPropertyName("actualWork")]
        public ActualWork ActualWork { get; set; }

        [JsonPropertyName("previousTasks")]
        public List<object> PreviousTasks { get; set; }

        [JsonPropertyName("nextTasksCount")]
        public int NextTasksCount { get; set; }

        [JsonPropertyName("actualFinish")]
        public object ActualFinish { get; set; }

        [JsonPropertyName("plannedFinish")]
        public object PlannedFinish { get; set; }

        [JsonPropertyName("duration")]
        public Duration Duration { get; set; }

        [JsonPropertyName("parents")]
        public List<object> Parents { get; set; }

        [JsonPropertyName("parentsCount")]
        public int ParentsCount { get; set; }

        [JsonPropertyName("project")]
        public object Project { get; set; }

        [JsonPropertyName("participants")]
        public List<Participant> Participants { get; set; }

        [JsonPropertyName("participantsCount")]
        public int ParticipantsCount { get; set; }

        [JsonPropertyName("statement")]
        public string Statement { get; set; }

        [JsonPropertyName("textStatement")]
        public string TextStatement { get; set; }

        [JsonPropertyName("milestones")]
        public List<object> Milestones { get; set; }

        [JsonPropertyName("milestonesCount")]
        public int MilestonesCount { get; set; }

        [JsonPropertyName("rights")]
        public Rights Rights { get; set; }

        [JsonPropertyName("relationLinks")]
        public List<object> RelationLinks { get; set; }

        [JsonPropertyName("relationLinksCount")]
        public int RelationLinksCount { get; set; }

        [JsonPropertyName("deals")]
        public List<object> Deals { get; set; }

        [JsonPropertyName("dealsCount")]
        public int DealsCount { get; set; }

        [JsonPropertyName("actualDealsCount")]
        public int ActualDealsCount { get; set; }

        [JsonPropertyName("linksCount")]
        public int LinksCount { get; set; }

        [JsonPropertyName("parent")]
        public object Parent { get; set; }

        [JsonPropertyName("workedOffTime")]
        public List<object> WorkedOffTime { get; set; }

        [JsonPropertyName("workedOffTimeCount")]
        public int WorkedOffTimeCount { get; set; }

        [JsonPropertyName("workedOffTimeTotal")]
        public WorkedOffTimeTotal WorkedOffTimeTotal { get; set; }

        [JsonPropertyName("todos")]
        public List<object> Todos { get; set; }

        [JsonPropertyName("todosCount")]
        public int TodosCount { get; set; }

        [JsonPropertyName("contractor")]
        public object Contractor { get; set; }

        [JsonPropertyName("timeCreated")]
        public TimeCreated TimeCreated { get; set; }

        [JsonPropertyName("deadlineChangeRequest")]
        public object DeadlineChangeRequest { get; set; }

        [JsonPropertyName("deadlineReminders")]
        public List<object> DeadlineReminders { get; set; }

        [JsonPropertyName("deadlineRemindersCount")]
        public int DeadlineRemindersCount { get; set; }

        [JsonPropertyName("responsibleCanEditExtFields")]
        public bool ResponsibleCanEditExtFields { get; set; }

        [JsonPropertyName("executorsCanEditExtFields")]
        public bool ExecutorsCanEditExtFields { get; set; }

        [JsonPropertyName("auditorsCanEditExtFields")]
        public bool AuditorsCanEditExtFields { get; set; }

        [JsonPropertyName("bonuses")]
        public List<object> Bonuses { get; set; }

        [JsonPropertyName("bonusesCount")]
        public int BonusesCount { get; set; }

        [JsonPropertyName("activity")]
        public Activity Activity { get; set; }

        [JsonPropertyName("isGroup")]
        public bool IsGroup { get; set; }

        [JsonPropertyName("entitiesByTemplate")]
        public List<object> EntitiesByTemplate { get; set; }

        [JsonPropertyName("userCreated")]
        public UserCreated UserCreated { get; set; }

        [JsonPropertyName("finalRating")]
        public object FinalRating { get; set; }

        [JsonPropertyName("messagesCount")]
        public int MessagesCount { get; set; }

        [JsonPropertyName("lastComment")]
        public object LastComment { get; set; }

        [JsonPropertyName("lastCommentTimeCreated")]
        public object LastCommentTimeCreated { get; set; }

        [JsonPropertyName("firstUnreadComment")]
        public object FirstUnreadComment { get; set; }

        [JsonPropertyName("negotiationItemsCount")]
        public int NegotiationItemsCount { get; set; }

        [JsonPropertyName("reminderTime")]
        public object ReminderTime { get; set; }

        [JsonPropertyName("fine")]
        public List<object> Fine { get; set; }

        [JsonPropertyName("fineCount")]
        public int FineCount { get; set; }

        [JsonPropertyName("interactionsCounters")]
        public List<object> InteractionsCounters { get; set; }

        [JsonPropertyName("editableFields")]
        public List<string> EditableFields { get; set; }

        [JsonPropertyName("isGrouped")]
        public bool IsGrouped { get; set; }

        [JsonPropertyName("decision")]
        public bool Decision { get; set; }

        [JsonPropertyName("visaOkCount")]
        public int VisaOkCount { get; set; }

        [JsonPropertyName("visaBadCount")]
        public int VisaBadCount { get; set; }

        [JsonPropertyName("shouldVisasCount")]
        public int ShouldVisasCount { get; set; }

        [JsonPropertyName("comments")]
        public List<object> Comments { get; set; }

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

        [JsonPropertyName("actualTodosCount")]
        public int ActualTodosCount { get; set; }

        [JsonPropertyName("finishedTodosCount")]
        public int FinishedTodosCount { get; set; }

        [JsonPropertyName("Category130CustomFieldTipTekst")]
        public string Category130CustomFieldTipTekst { get; set; }

        [JsonPropertyName("Category130CustomFieldTipChislo")]
        public object Category130CustomFieldTipChislo { get; set; }

        [JsonPropertyName("Category130CustomFieldTipDaNet")]
        public bool Category130CustomFieldTipDaNet { get; set; }

        [JsonPropertyName("Category130CustomFieldTipBolshoeChislo")]
        public string Category130CustomFieldTipBolshoeChislo { get; set; }

        [JsonPropertyName("Category130CustomFieldTipVibor")]
        public string Category130CustomFieldTipVibor { get; set; }

        [JsonPropertyName("Category130CustomFieldTipUnikalniyTekst")]
        public string Category130CustomFieldTipUnikalniyTekst { get; set; }

        [JsonPropertyName("Category130CustomFieldOtsenka1")]
        public int Category130CustomFieldOtsenka1 { get; set; }

        [JsonPropertyName("Category130CustomFieldOtsenka1VoteCount")]
        public int Category130CustomFieldOtsenka1VoteCount { get; set; }

        [JsonPropertyName("Category130CustomFieldOtsenka1UserVote")]
        public int Category130CustomFieldOtsenka1UserVote { get; set; }

        [JsonPropertyName("Category130CustomFieldOtsenka2")]
        public int Category130CustomFieldOtsenka2 { get; set; }

        [JsonPropertyName("Category130CustomFieldOtsenka2VoteCount")]
        public int Category130CustomFieldOtsenka2VoteCount { get; set; }

        [JsonPropertyName("Category130CustomFieldOtsenka2UserVote")]
        public int Category130CustomFieldOtsenka2UserVote { get; set; }

        [JsonPropertyName("Category130CustomFieldOtsenka3")]
        public int Category130CustomFieldOtsenka3 { get; set; }

        [JsonPropertyName("Category130CustomFieldOtsenka3VoteCount")]
        public int Category130CustomFieldOtsenka3VoteCount { get; set; }

        [JsonPropertyName("Category130CustomFieldOtsenka3UserVote")]
        public int Category130CustomFieldOtsenka3UserVote { get; set; }

        [JsonPropertyName("Category130CustomFieldFayliki")]
        public List<object> Category130CustomFieldFayliki { get; set; }

        [JsonPropertyName("Category130CustomFieldPlanFakt")]
        public Category130CustomFieldPlanFakt Category130CustomFieldPlanFakt { get; set; }

        [JsonPropertyName("ratingFieldsCount")]
        public int RatingFieldsCount { get; set; }

        [JsonPropertyName("isFavorite")]
        public bool IsFavorite { get; set; }

        [JsonPropertyName("lastView")]
        public object LastView { get; set; }

        [JsonPropertyName("tags")]
        public List<object> Tags { get; set; }

        [JsonPropertyName("tagsCount")]
        public int TagsCount { get; set; }

        [JsonPropertyName("financeOperations")]
        public List<object> FinanceOperations { get; set; }

        [JsonPropertyName("financeOperationsCount")]
        public int FinanceOperationsCount { get; set; }

        [JsonPropertyName("allFiles")]
        public List<object> AllFiles { get; set; }

        [JsonPropertyName("allFilesCount")]
        public int AllFilesCount { get; set; }

        [JsonPropertyName("attachesInfo")]
        public AttachesInfo AttachesInfo { get; set; }

        [JsonPropertyName("hiddenCommentsCount")]
        public int HiddenCommentsCount { get; set; }

        [JsonPropertyName("kpiStart")]
        public object KpiStart { get; set; }

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

    public class Department
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class Duration
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("value")]
        public int Value { get; set; }
    }

    public class ContactInfo
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("comment")]
        public string Comment { get; set; }

        [JsonPropertyName("isMain")]
        public bool? IsMain { get; set; }

        [JsonPropertyName("subject")]
        public Subject Subject { get; set; }
    }

    public class LastOnline
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("value")]
        public DateTime Value { get; set; }
    }

    public class Meta
    {
        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("errors")]
        public List<object> Errors { get; set; }

        [JsonPropertyName("pagination")]
        public List<object> Pagination { get; set; }
    }

    public class Owner
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("middleName")]
        public string MiddleName { get; set; }

        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        [JsonPropertyName("position")]
        public string Position { get; set; }

        [JsonPropertyName("department")]
        public Department Department { get; set; }

        [JsonPropertyName("uid")]
        public int Uid { get; set; }

        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("birthday")]
        public object Birthday { get; set; }

        [JsonPropertyName("inn")]
        public string Inn { get; set; }

        [JsonPropertyName("contactInfo")]
        public List<ContactInfo> ContactInfo { get; set; }

        [JsonPropertyName("contactInfoCount")]
        public int ContactInfoCount { get; set; }

        [JsonPropertyName("isWorking")]
        public bool IsWorking { get; set; }

        [JsonPropertyName("nearestVacation")]
        public object NearestVacation { get; set; }

        [JsonPropertyName("isReadable")]
        public bool IsReadable { get; set; }

        [JsonPropertyName("isOnline")]
        public bool IsOnline { get; set; }

        [JsonPropertyName("lastOnline")]
        public LastOnline LastOnline { get; set; }

        [JsonPropertyName("canLogin")]
        public bool CanLogin { get; set; }

        [JsonPropertyName("avatar")]
        public object Avatar { get; set; }
    }

    public class Participant
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }
    }

    public class PlannedWork
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("value")]
        public int Value { get; set; }
    }

    public class Responsible
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }
    }

    public class Rights
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("read")]
        public bool Read { get; set; }

        [JsonPropertyName("edit")]
        public bool Edit { get; set; }

        [JsonPropertyName("remove")]
        public bool Remove { get; set; }

        [JsonPropertyName("updateDeepLastActivity")]
        public bool UpdateDeepLastActivity { get; set; }

        [JsonPropertyName("acceptWork")]
        public bool AcceptWork { get; set; }

        [JsonPropertyName("rejectWork")]
        public bool RejectWork { get; set; }

        [JsonPropertyName("acceptTask")]
        public bool AcceptTask { get; set; }

        [JsonPropertyName("rejectTask")]
        public bool RejectTask { get; set; }

        [JsonPropertyName("acceptDeadline")]
        public bool AcceptDeadline { get; set; }

        [JsonPropertyName("rejectDeadline")]
        public bool RejectDeadline { get; set; }

        [JsonPropertyName("changeDeadline")]
        public bool ChangeDeadline { get; set; }

        [JsonPropertyName("requestDeadline")]
        public bool RequestDeadline { get; set; }

        [JsonPropertyName("createSubtask")]
        public bool CreateSubtask { get; set; }

        [JsonPropertyName("createNegotiationSubtask")]
        public bool CreateNegotiationSubtask { get; set; }

        [JsonPropertyName("editExecutors")]
        public bool EditExecutors { get; set; }

        [JsonPropertyName("editExtFields")]
        public bool EditExtFields { get; set; }

        [JsonPropertyName("readMilestone")]
        public bool ReadMilestone { get; set; }

        [JsonPropertyName("createMilestone")]
        public bool CreateMilestone { get; set; }

        [JsonPropertyName("createFinOperation")]
        public bool CreateFinOperation { get; set; }

        [JsonPropertyName("convert")]
        public bool Convert { get; set; }

        [JsonPropertyName("delegate")]
        public bool Delegate { get; set; }

        [JsonPropertyName("readBonuses")]
        public bool ReadBonuses { get; set; }

        [JsonPropertyName("linkDeal")]
        public bool LinkDeal { get; set; }

        [JsonPropertyName("takeup")]
        public bool Takeup { get; set; }

        [JsonPropertyName("useTemplate")]
        public bool UseTemplate { get; set; }

        [JsonPropertyName("toTemplate")]
        public bool ToTemplate { get; set; }

        [JsonPropertyName("changeOwner")]
        public bool ChangeOwner { get; set; }

        [JsonPropertyName("pause")]
        public bool Pause { get; set; }

        [JsonPropertyName("resume")]
        public bool Resume { get; set; }

        [JsonPropertyName("cancel")]
        public bool Cancel { get; set; }

        [JsonPropertyName("expire")]
        public bool Expire { get; set; }

        [JsonPropertyName("done")]
        public bool Done { get; set; }

        [JsonPropertyName("renew")]
        public bool Renew { get; set; }

        [JsonPropertyName("rateVoteAvailable")]
        public bool RateVoteAvailable { get; set; }

        [JsonPropertyName("rateVoteWillBeAvailable")]
        public bool RateVoteWillBeAvailable { get; set; }

        [JsonPropertyName("rateResultsAvailable")]
        public bool RateResultsAvailable { get; set; }

        [JsonPropertyName("rateCustomVoteAvailable")]
        public bool RateCustomVoteAvailable { get; set; }

        [JsonPropertyName("rateChangeVoteAvailable")]
        public bool RateChangeVoteAvailable { get; set; }

        [JsonPropertyName("rateSeeVote")]
        public bool RateSeeVote { get; set; }

        [JsonPropertyName("rateWidgetAvailable")]
        public bool RateWidgetAvailable { get; set; }

        [JsonPropertyName("reminderRecipient")]
        public bool ReminderRecipient { get; set; }

        [JsonPropertyName("editMainInfo")]
        public bool EditMainInfo { get; set; }

        [JsonPropertyName("changeContractor")]
        public bool ChangeContractor { get; set; }

        [JsonPropertyName("addNewNegotiationItem")]
        public bool AddNewNegotiationItem { get; set; }

        [JsonPropertyName("deleteNegotiationItem")]
        public bool DeleteNegotiationItem { get; set; }

        [JsonPropertyName("editNegotiationItemVersion")]
        public bool EditNegotiationItemVersion { get; set; }
    }

    public class Activity
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("value")]
        public DateTime Value { get; set; }
    }

    public class ActualStart
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("value")]
        public DateTime Value { get; set; }
    }

    public class ActualWork
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("value")]
        public int Value { get; set; }
    }

    public class AttachesInfo
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("imageFiles")]
        public List<object> ImageFiles { get; set; }

        [JsonPropertyName("imageFilesCount")]
        public int ImageFilesCount { get; set; }

        [JsonPropertyName("audioFiles")]
        public List<object> AudioFiles { get; set; }

        [JsonPropertyName("audioFilesCount")]
        public int AudioFilesCount { get; set; }

        [JsonPropertyName("otherFiles")]
        public List<object> OtherFiles { get; set; }

        [JsonPropertyName("otherFilesCount")]
        public int OtherFilesCount { get; set; }
    }

    public class Category130CustomFieldPlanFakt
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("planned")]
        public int Planned { get; set; }

        [JsonPropertyName("actual")]
        public int Actual { get; set; }
    }

    public class RootTaskMPResponse
    {
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }

        [JsonPropertyName("data")]
        public TaskResponse Data { get; set; }
    }

    public class StatusChangeTime
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("value")]
        public DateTime Value { get; set; }
    }

    public class Subject
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }
    }

    public class TimeCreated
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("value")]
        public DateTime Value { get; set; }
    }

    public class UserCreated
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }
    }

    public class WorkedOffTimeTotal
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("value")]
        public int Value { get; set; }
    }

}
