using Hangfire.Annotations;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.MediatR
{

    [UsedImplicitly]
    public class PingCommandHandler
      : IRequestHandler<PingCommand, PongResponse>
    {
        public async Task<PongResponse> Handle(PingCommand request,
          CancellationToken cancellationToken)
        {
            return await Task
              .FromResult(new PongResponse(DateTime.UtcNow))
              .ConfigureAwait(false);
        }
    }
}
