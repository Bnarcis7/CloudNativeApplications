using Grpc.Net.Client;
using GrpcServer;
using System;

namespace GrpcClient
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            //Console.WriteLine("Enter number of clients:");
            //var n =Int32.Parse(Console.ReadLine());

            while (true)
            {
                var client = new AskName.AskNameClient(channel);
                Console.WriteLine("Enter your name:");
                var name = new NameRequest { Name = Console.ReadLine() };
                var reply = await client.AskNameAsync(name);
            }
           



        }

         
    }
}
