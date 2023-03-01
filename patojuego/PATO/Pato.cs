using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patojuego.PATO
{
   abstract public class Pato 
    {
      public IFlyBehavior flyBehavior;
      public IQuackBehavior quackBehavior;
        public Pato()
        {
              
        }

         public abstract void display();

        public void PerformFly()
        {
            flyBehavior.fly();
        }
        public void PerformQuack()
        {
            quackBehavior.quack();
        }


    }
}
