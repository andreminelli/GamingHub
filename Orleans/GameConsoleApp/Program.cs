using GrainInterfaces;
using Microsoft.Extensions.Logging;
using Orleans;
using Orleans.Configuration;
using System;
using System.Threading.Tasks;

namespace GameConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var client = await ConnectClientAsync();
            var loginWorker = client.GetGrain<ILoginWorker>(Guid.Empty);
            var result = await loginWorker.LoginAsync(new LoginRequest { Name = "Andre Minelli" });
            var outputWriter = result.IsSuccess ? Console.Out : Console.Error;
            outputWriter.WriteLine(result.Message);
        }

        private static async Task<IClusterClient> ConnectClientAsync()
        {
            var client = new ClientBuilder()
                .UseLocalhostClustering()
                .Configure<ClusterOptions>(options =>
                {
                    options.ClusterId = "dev";
                    options.ServiceId = "GamingHub";
                })
                .ConfigureLogging(logging => logging.AddDebug())
                .Build();

            await client.Connect();

            Console.WriteLine("Client successfully connected to silo host \n");
            return client;
        }

    }
}
