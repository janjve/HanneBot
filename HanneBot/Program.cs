﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanneBot
{
    class Program
    {
        static void Main(string[] args) => new HBot()
            .Run()
            .GetAwaiter()
            .GetResult();
    }
}
