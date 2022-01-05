using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnClick
{
    public class Message
    {

        public bool isRead { get; set; }
        public bool isReport { get; set; }
        public Report Report { get; set; }

        public string from { get; set; }

        public override string ToString()
        {
            return Report.info;
        }
    }
}
