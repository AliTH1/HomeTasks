﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskException.Utilities.Exceptions
{
    internal class AgeException : Exception
    {
        public AgeException(string message) : base(message)
        {

        }
    }
}
