using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patojuego.PATO
{
    public  class ModelDuck : Pato
    {
        
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
          
        }
        public override void display()
        {
            Console.WriteLine("SOY UN PATO DEFAULT XD");
        }
    }
}
