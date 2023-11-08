using Lab.Orleans.GrainInterfaces;

namespace Lab.Orleans.Grains;

public class HelloWorld : Grain, IHelloWorld
{
    public Task<string> SayHello(string name)
    {
        return Task.FromResult($"Hello World! Orleans welcomes {name}");
    }
}
