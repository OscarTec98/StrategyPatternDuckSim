using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patojuego.PATO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejemplo de instanciacion de un pato modelo para comprobar funcionalidad
            Pato modelo = new ModelDuck();
            modelo.PerformQuack();
            modelo.PerformFly();
            modelo.display();
            Console.ReadKey();
        }
    }
}
