using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnClick
{
    public class IndexNotFoundException : Exception
    {
        public IndexNotFoundException(string message) : base(message)
        {
        }
    }
}
