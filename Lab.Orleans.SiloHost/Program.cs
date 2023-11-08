using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Orleans.Configuration;

try
{
    var builder = new HostBuilder()
        .UseOrleans(c =>
        {            
            c.UseLocalhostClustering()            
            .Configure<ClusterOptions>(options =>
            {
                options.ClusterId = "dev";
                options.ServiceId = "HelloWorld";
            })
            .ConfigureLogging(logging => logging.AddConsole())
            .UseDashboard();
        });

    var host = builder.Build();
    await host.StartAsync();

    Console.WriteLine("\n\n Press Enter to terminate...\n\n");
    Console.ReadLine();

    await host.StopAsync();

    return 0;   // integer required
}
catch (Exception ex)
{
    Console.WriteLine(ex);
    return 1;   // integer required
}