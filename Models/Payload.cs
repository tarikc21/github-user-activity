using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GitHubUserActivity.Models
{
    public class Payload
    {
        [JsonPropertyName("size")]
        public int Size { get; set; }
    }
}
