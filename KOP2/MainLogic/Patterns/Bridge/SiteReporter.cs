using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLogic.Patterns.Bridge
{
    public class SiteReporter : IDataRepository
    {
        public string obtainData()
        {
            return "data rep";
        }
    }
}
