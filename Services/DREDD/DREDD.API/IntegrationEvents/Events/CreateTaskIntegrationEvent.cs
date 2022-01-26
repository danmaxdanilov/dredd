using EventBus.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DREDD.API.IntegrationEvents.Events
{
    public class CreateTaskIntegrationEvent: IntegrationEvent
    {
        public CreateTaskIntegrationEvent()
        {
            Types = new List<int>();
        }
        public int TaskType { get; set; }
        public List<int> Types { get; set; }
    }
}
