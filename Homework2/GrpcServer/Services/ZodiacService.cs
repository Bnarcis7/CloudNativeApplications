using Grpc.Core;
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcServer.Services
{
    public class ZodiacService :Zodiac.ZodiacBase
    {
        public override Task<ZodiacResponse> GetZodiacSign(DateRequest request, ServerCallContext context)
        {
            string startDate;
            string endDate;
            string ZodiacSign;
            var path = File.ReadAllLines("ZodiacDates.txt");
            DateTime requested;
            DateTime start;
            DateTime end;

            for (var i = 0; i < path.Length; i += 3)
            {
                startDate = path.ElementAt(i).ToString();
                endDate = path.ElementAt(i + 1).ToString();
                ZodiacSign = path.ElementAt(i + 2).ToString();

                if (DateTime.TryParseExact(startDate, "MM/dd/yyyy", null, DateTimeStyles.None, out start)&& DateTime.TryParseExact(endDate, "MM/dd/yyyy", null, DateTimeStyles.None, out end)&& DateTime.TryParseExact(request.Date, "MM/dd/yyyy", null, DateTimeStyles.None, out requested))
                {
                    if (((start.Month < requested.Month) || (start.Month == requested.Month && start.Day <= requested.Day)) && ((end.Month > requested.Month) || (end.Month == requested.Month) && end.Day >= requested.Day))
                    {
                        return Task.FromResult(new ZodiacResponse { Sign = ZodiacSign });
                    }

                }

            }
            return Task.FromResult(new ZodiacResponse { Sign = "Invalid input" });

        }
    }
}
