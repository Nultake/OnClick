﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnClick
{
    public class AdvertListEmptyException : Exception
    {
        public AdvertListEmptyException(string message) : base(message)
        {
        }
    }
}
