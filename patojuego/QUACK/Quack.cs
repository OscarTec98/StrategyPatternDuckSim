﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patojuego
{
    internal class Quack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("quack...");

        }
    }
}
