﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnClick
{
    public class PasswordDoesNotMatchException : Exception
    {
        public PasswordDoesNotMatchException(string message) : base(message)
        {
        }
    }
}
