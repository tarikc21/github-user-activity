using GitHubUserActivity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubUserActivity.Utils
{
    public class EventFormatter
    {
        public static void PrintEvents(List<GitHubEvent> events)
        {
            foreach (var ev in events.Take(10))
            {
                string message = FormatEvent(ev);

                if (!string.IsNullOrEmpty(message))
                {
                    Console.WriteLine(message);
                }
            }
        }

        private static string FormatEvent(GitHubEvent ev)
        {
            switch (ev.Type)
            {
                case "PushEvent":
                    return $"Pushed {ev.Payload?.Size ?? 0} commits to {ev.Repo?.Name}";

                case "IssuesEvent":
                    return $"Opened issue in {ev.Repo?.Name}";

                case "WatchEvent":
                    return $"Starred {ev.Repo?.Name}";

                case "ForkEvent":
                    return $"Forked {ev.Repo?.Name}";

                default:
                    return $"{ev.Type} in {ev.Repo?.Name}";
            }
        }
    }
}
