﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnClick
{
    public class Report
    {
        public string info { get; set; }
        public Advert Advert { get; set; }

        public override string ToString()
        {
            return Advert.title + info;
        }
    }
}
