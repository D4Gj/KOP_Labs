using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLogic.Patterns.State
{
    public class DoneEvent : EventState
    {
        public DoneEvent(Event Event) : base(Event)
        {
        }

        public override string notify()
        {
            /*
             * one of evnts ready
             */
            return "DONE ";
        }
    }
}
