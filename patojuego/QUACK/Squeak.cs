﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patojuego.QUACK
{
    internal class Squeak : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Squeak....");
        }
    }
}
