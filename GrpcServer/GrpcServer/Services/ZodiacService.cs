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
            string pattern = "MM/dd/yyyy";
            var path = File.ReadAllLines("ZodiacDates.txt");

            DateTime requestParsed;
            DateTime startParsed;
            DateTime endParsed;

            for (var i = 0; i < path.Length; i += 3)
            {
                startDate = path.ElementAt(i).ToString();
                endDate = path.ElementAt(i + 1).ToString();
                ZodiacSign = path.ElementAt(i + 2).ToString();

                if (DateTime.TryParseExact(startDate, pattern, null, DateTimeStyles.None, out startParsed)&& DateTime.TryParseExact(endDate, pattern, null, DateTimeStyles.None, out endParsed)&& DateTime.TryParseExact(request.Date, pattern, null, DateTimeStyles.None, out requestParsed))
                {
                    if (((startParsed.Month < requestParsed.Month) || (startParsed.Month == requestParsed.Month && startParsed.Day <= requestParsed.Day)) && ((endParsed.Month > requestParsed.Month) || (endParsed.Month == requestParsed.Month) && endParsed.Day >= requestParsed.Day))
                    {
                        return Task.FromResult(new ZodiacResponse { Sign = ZodiacSign });
                    }

                }

            }
            return Task.FromResult(new ZodiacResponse { Sign = "Invalid input" });

        }
    }
}
