using Grpc.Net.Client;
using GrpcServer;
using System;
using System.Globalization;

namespace GrpcClient
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var channel = GrpcChannel.ForAddress("https://localhost:5001");
                var client = new Zodiac.ZodiacClient(channel);
                string input = InputValidation();
                Console.WriteLine("Zodiac Sign: " + client.GetZodiacSign(new DateRequest { Date = input }).Sign.ToString());
            }
        }

        public static string InputValidation()
        {
            Console.WriteLine("\nEnter your birthdate (MM/DD/YYYY): ");
            string input = Console.ReadLine();
            string pattern = "MM/dd/yyyy";
            DateTime parsedDate;

            while (!DateTime.TryParseExact(input, pattern, null, DateTimeStyles.None, out parsedDate))
            {
                Console.WriteLine("Incorrect input! Please enter your birthday: ");
                input = Console.ReadLine();
            }

            return input;

        }


    }
}
