using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLogic.Patterns.State
{
    public class NewEvent : EventState
    {
        public NewEvent(Event Event) : base(Event)
        {
        }

        public override string notify()
        {
            /*
             * one of evnts ready
             */
            Event.ChangeState(new PlanEvent(Event));           
            return "NEW event";
        }
    }
}
