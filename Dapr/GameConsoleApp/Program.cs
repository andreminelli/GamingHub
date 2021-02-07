using Dapr.Client;
using System;
using System.Threading.Tasks;
using UserService.Contracts;

namespace GameConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new DaprClientBuilder().Build();

            var request = new LoginRequest { Name = "Andre Minelli" };
            var result = await client.InvokeMethodAsync<LoginRequest, LoginResponse>("userService", "UserService/Login", request);
            var outputWriter = result.IsSuccess ? Console.Out : Console.Error;
            outputWriter.WriteLine(result.Message);

        }
    }
}
