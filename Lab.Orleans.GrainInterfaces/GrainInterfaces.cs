namespace Lab.Orleans.GrainInterfaces;

public interface IHelloWorld : IGrainWithIntegerKey
{
    Task<string> SayHello(string name);
}
