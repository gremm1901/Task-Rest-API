namespace AutotestAPI.Entities.Megaplan.Responses
{
    public class AuditorResponse
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
        public object Department { get; set; }

        [JsonPropertyName("uid")]
        public int Uid { get; set; }

        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("birthday")]
        public object Birthday { get; set; }

        [JsonPropertyName("inn")]
        public string Inn { get; set; }

        [JsonPropertyName("contactInfo")]
        public List<ContactInfoResponse> ContactInfo { get; set; }

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
        public object LastOnline { get; set; }

        [JsonPropertyName("canLogin")]
        public bool CanLogin { get; set; }

        [JsonPropertyName("avatar")]
        public object Avatar { get; set; }
    }
}
