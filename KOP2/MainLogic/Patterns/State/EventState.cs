using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLogic.Patterns.State
{
    public abstract class EventState
    {
        public Event Event { get; }

        public EventState(Event Event)
        {
            this.Event = Event;
        }

        public abstract string notify();
    }
}
