namespace AutotestAPI
{
    internal class CreateMassUserRequest
    {
        [JsonPropertyName("")]
        public List<CreateUserRequest> Mass { get; set; }
    }
}
