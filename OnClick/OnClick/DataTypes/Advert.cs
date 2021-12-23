using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnClick
{
    public class Advert
    {
        public static List<Advert> adverts = new List<Advert>();
        public bool isAvailable { get; set; }
        public bool isWarned { get; set; }
        public string phoneNumber { get; set; }
        public DateTime releaseDate { get; set; }
        public string title { get; set; }
        public Product product { get; set; }
        public User user { get; set; }

        public Advert()
        {
            adverts.Add(this);
        }
        public override string ToString()
        {
            return title+ product + releaseDate+ isAvailable+ user+ phoneNumber+ isWarned ;
        }
    }
}
