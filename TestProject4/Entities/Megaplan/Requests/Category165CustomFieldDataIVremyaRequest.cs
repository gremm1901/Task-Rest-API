using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutotestAPI.Entities.Megaplan.Requests
{
    public class Category165CustomFieldDataIVremyaRequest
    {
        [JsonPropertyName("contentType")]
        public string ContentType { get; set; }

        [JsonPropertyName("value")]
        public DateTime Value { get; set; }
    }
}
