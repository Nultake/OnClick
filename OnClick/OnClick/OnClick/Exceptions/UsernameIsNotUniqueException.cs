using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnClick
{
    public class UsernameIsNotUniqueException : Exception
    {
        public UsernameIsNotUniqueException(string message) : base(message)
        {
        }
    }
}
