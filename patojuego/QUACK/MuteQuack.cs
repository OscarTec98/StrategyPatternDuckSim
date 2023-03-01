using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patojuego.QUACK
{
    internal class MuteQuack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("...............");
        }
    }
}
