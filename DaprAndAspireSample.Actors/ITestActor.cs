using Dapr.Actors;

namespace DaprAndAspireSample.Actors;

public interface ITestActor : IActor
{
    Task<string> EchoAsync(string message);
}
