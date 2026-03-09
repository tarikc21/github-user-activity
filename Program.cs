using GitHubUserActivity.Services;
using GitHubUserActivity.Utils;

if (args.Length == 0)
{
    Console.WriteLine("Please provide a GitHub username.");
    Console.WriteLine("Example: dotnet run tarikc21");
    return;
}

string username = args[0];

var service = new GitHubService();

var events = await service.GetUserActivity(username);

Console.WriteLine($"Events fetched: {events.Count}");
EventFormatter.PrintEvents(events);
