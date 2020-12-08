using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLogic.Patterns.Bridge
{
    public class JsonReporter : IReporter
    {
        private IDataRepository dataRepository;

        public JsonReporter(IDataRepository dataRepository)
        {
            this.dataRepository = dataRepository;
        }
        public string createReport()
        {
            return "Json report from " + dataRepository.obtainData();
        }
    }
}
