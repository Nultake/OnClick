using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnClick
{
    public class Guest : NonAuthorizedAccount
    {
        public Guest()
        {
            this.name = "Guest" + counter++;
        }
    }

}
