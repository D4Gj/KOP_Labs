using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLogic.Patterns.Bridge
{
    public interface IReporter
    {
        string createReport();
    }
}
