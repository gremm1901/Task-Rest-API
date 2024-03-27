namespace AutotestAPI
{
    public class LoginUserPFSResponse:ErrorLoginUserPFSResponse
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; set; }
    }
}
