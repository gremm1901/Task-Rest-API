namespace AutotestAPI.Entities.Megaplan.Responses
{
    public class RightsResponse
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
}
