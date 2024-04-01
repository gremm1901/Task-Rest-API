namespace AutotestAPI.Entities.reqres.Responses
{
    public class ErrorClientResponse
    {
        [JsonPropertyName("error")]
        public string Error { get; set; }
    }
}