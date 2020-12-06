using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    [Serializable]
    public class ClassAmountEmployes
    {             
        public List<string> name { get; set; }    
        public List<int> amount { get; set; }
    }
}
