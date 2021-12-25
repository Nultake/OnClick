﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnClick
{
    public class Message
    {
        public bool isReport { get; set; } //If a message is about reporting an ad.
        public bool isRead { get; set; }
        public Report Report { get; set; }

        public override string ToString()
        {
            return base.ToString()+ isRead;
        }
    }
}