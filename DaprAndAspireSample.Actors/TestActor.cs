using Dapr.Actors.Runtime;

namespace DaprAndAspireSample.Actors;

public sealed class TestActor(ActorHost host) : Actor(host), ITestActor
{
    public async Task<string> EchoAsync(string message)
    {
        this.Logger.LogInformation("Echoing {Message}", message);

        await Task.Delay(TimeSpan.FromSeconds(2));

        return message;
    }
}
