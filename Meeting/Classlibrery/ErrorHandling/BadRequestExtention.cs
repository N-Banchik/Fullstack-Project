﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ErrorHandling
{
    public class BadRequestExtention:Exception
    {
        public BadRequestExtention(string message)
        : base(message)
        {
        }
        public BadRequestExtention(string message, Exception inner)
       : base(message, inner)
        {
        }
    }
}
