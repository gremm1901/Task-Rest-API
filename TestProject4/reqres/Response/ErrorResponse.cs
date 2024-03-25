namespace AutotestAPI
{
    public class ErrorClientResponse
    {
        [JsonPropertyName("error")]
        public string Error { get; set; }
    }
}