using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Messaging.NServiceBus
{
    public class NServiceBusEventDispatcher : IEventDispatcher
    {
        protected IBus Bus { get; private set; }

        public NServiceBusEventDispatcher(IBus bus)
        {
            if (bus == null)
                throw new ArgumentNullException(nameof(bus));

            Bus = bus;
        }

        public void Dispatch<T>(T @event) where T : DomainEvent
        {
            if (@event == null)
                throw new ArgumentNullException(nameof(@event));

            Bus.Publish(@event);
        }
    }
}
