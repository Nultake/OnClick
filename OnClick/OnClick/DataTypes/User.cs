using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnClick
{
    public class User : AuthorizedAccount
    {
        public User() : base()
        {
        }

        public bool isBanned { get; set; }
        public List<Advert> adverts { get; set; }
        public void AddAdvert(Advert advert)
        {

        }
        public void UpdateAdvert(Advert advert)
        {
            
        }
    }
}
