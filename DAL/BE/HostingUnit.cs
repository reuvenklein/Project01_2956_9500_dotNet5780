using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class HostingUnit
    {
        public string HostingUnitKey { get; set; }
        public Host Owner { get; set; }
        public string HostingUnitName { get; set; }
       public bool[,] Diary = new bool[12, 31];
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
