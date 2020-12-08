using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLogic.Patterns.Bridge
{
    public class TxtReporter:IReporter
    {
        private IDataRepository dataRepository;

        public TxtReporter(IDataRepository dataRepository)
        {
            this.dataRepository = dataRepository;
        }
        public string createReport()
        {
            return "Txt report from " + dataRepository.obtainData();
        }
    }
}
