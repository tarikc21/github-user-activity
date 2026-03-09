using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GitHubUserActivity.Models
{
    public class Repo
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }
}
