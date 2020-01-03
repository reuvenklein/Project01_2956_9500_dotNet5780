using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    class Order
    {
        public string HostingUnitKey { get; set; }
        public string GuestRequestKey { get; set; }
        public string OrderKey { get; set; }
        public string Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime OrderDate { get; set; }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
