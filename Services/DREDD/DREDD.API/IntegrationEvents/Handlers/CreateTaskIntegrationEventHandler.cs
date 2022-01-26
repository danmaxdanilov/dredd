using DREDD.API.IntegrationEvents.Events;
using EventBus.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DREDD.API.IntegrationEvents.Handlers
{
    public class CreateTaskIntegrationEventHandler : IIntegrationEventHandler<CreateTaskIntegrationEvent>
    {
        public async Task Handle(CreateTaskIntegrationEvent @event)
        {
            throw new NotImplementedException();
        }
    }
}
