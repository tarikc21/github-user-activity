using GitHubUserActivity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GitHubUserActivity.Services
{
    public class GitHubService
    {
        private readonly HttpClient client = new HttpClient();

        public async Task<List<GitHubEvent>> GetUserActivity(string username)
        {
            string url = $"https://api.github.com/users/{username}/events";

            client.DefaultRequestHeaders.UserAgent.ParseAdd("C# App");

            var response = await client.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                Console.WriteLine("Error fetching data from GitHub.");
                return new List<GitHubEvent>();
            }

            string json = await response.Content.ReadAsStringAsync();
            Console.WriteLine(json);

            var events = JsonSerializer.Deserialize<List<GitHubEvent>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return events ?? new List<GitHubEvent>();
        }
    }
}
