using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLogic.Patterns.State
{
    public class Event
    {
        private EventState _eventState;
        public EventState EventState { get { return _eventState; } }

        public void ChangeState(EventState EventState)
        {
            _eventState = EventState;
        }
        public string notify()
        {
            return _eventState.notify();
        }
    }
}
