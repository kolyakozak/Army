using System;
using System.Collections.Generic;
using System.Text;

namespace Army
{
    class Airplane: ITransport
    {
        public void Display()
        {
            Console.WriteLine("Airplane - conducts air transportation and attacks");
        }
        public void Deliver(string forwObject)
        {
            Console.WriteLine($"Delivering the {forwObject} by air");
        }
        public void Attack(string target)
        {
            Console.WriteLine($"Attacking the {target} by air");
        }
    }
}
