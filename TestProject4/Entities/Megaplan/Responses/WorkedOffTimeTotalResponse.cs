﻿namespace AutotestAPI.Entities.Megaplan.Responses
{
    public class WorkedOffTimeTotalResponse
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("value")]
        public int Value { get; set; }
    }
}
