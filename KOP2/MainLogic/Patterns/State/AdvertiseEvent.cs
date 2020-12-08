using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLogic.Patterns.State
{
    public class AdvertiseEvent : EventState
    {
        public AdvertiseEvent(Event Event) : base(Event)
        {
        }

        public override string notify()
        {
            /*
             * one of evnts ready
             */
            Event.ChangeState(new DoneEvent(Event));
            
            return "ADVERTISE event";
        }
    }
}
