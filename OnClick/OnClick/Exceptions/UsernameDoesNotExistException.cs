using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnClick
{
    public class UsernameDoesNotExistException : Exception
    {
        public UsernameDoesNotExistException(string message) : base(message)
        {
        }
    }
}
