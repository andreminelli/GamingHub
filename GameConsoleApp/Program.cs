using Grpc.Net.Client;
using ProtoBuf.Grpc.Client;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using UserService.Contracts;

namespace GameConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //GrpcClientFactory.AllowUnencryptedHttp2 = true;
            var httpHandler = new HttpClientHandler();            
            httpHandler.ServerCertificateCustomValidationCallback =
                HttpClientHandler.DangerousAcceptAnyServerCertificateValidator; // Return `true` to allow certificates that are untrusted/invalid
            using var channel = GrpcChannel.ForAddress("https://localhost:5004",
                new GrpcChannelOptions { HttpHandler = httpHandler });
            var loginService = channel.CreateGrpcService<ILoginService>();
            var result = await loginService.LoginAsync(new LoginRequest { Name = "Andre Minelli" });
            var outputWriter = result.IsSuccess ? Console.Out : Console.Error;
            outputWriter.WriteLine(result.Message);
        }
    }
}
