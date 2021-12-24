using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnClick
{
    public class Admin : AuthorizedAccount
    {
        public Admin() : base()
        {
        }

        public void ApproveWarnAdvert(Advert advert)
        {
            
        }  
        public void Ban(User user)
        {
            user.isBanned = true;
        }
        public void PromoteToAdmin(User user)
        {
            
        }
        public void WarnAdvert(Advert advert)

        {
            
        }
    }
}
