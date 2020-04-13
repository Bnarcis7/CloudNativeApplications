using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace GrpcServer
{
    public class AskNameService : AskName.AskNameBase
    {
        private readonly ILogger<AskNameService> _logger;
        public AskNameService(ILogger<AskNameService> logger)
        {
            _logger = logger;
        }

        public override Task<NameReply>AskName(NameRequest request, ServerCallContext context)
        {
            Console.WriteLine(request.Name);
            return Task.FromResult(new NameReply
            {
                Message = request.Name
                
            });
             
           
        }


      
    }
}
