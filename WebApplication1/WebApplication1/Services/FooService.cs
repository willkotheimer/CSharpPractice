﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Services
{
    public class FooService
    {
        public List<string> GetNames()
        {
            return new List<string>()
            {
                "Bob",
                "Mary",
                "John",
                "Jane"
            };
        }
    }
}
