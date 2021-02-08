using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace GameConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var httpHandler = new HttpClientHandler
            {
                ServerCertificateCustomValidationCallback =
                HttpClientHandler.DangerousAcceptAnyServerCertificateValidator // Return `true` to allow certificates that are untrusted/invalid
            };
            using var httpClient = new HttpClient(httpHandler)
            {
                BaseAddress = new Uri("http://localhost:5001")
            };
            var loginService = new UserServiceClient(httpClient);
            var result = await loginService.LoginAsync(new LoginRequest { Name = "Andre Minelli" });
            var outputWriter = result.IsSuccess ? Console.Out : Console.Error;
            outputWriter.WriteLine(result.Message);
        }
    }
}
