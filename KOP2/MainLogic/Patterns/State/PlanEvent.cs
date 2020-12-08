using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLogic.Patterns.State
{
    public class PlanEvent : EventState
    {
        public PlanEvent(Event Event) : base(Event)
        {
        }

        public override string notify()
        {
            
            Event.ChangeState(new AdvertiseEvent(Event));            
            return "PLAN evnt";
        }
    }
}
