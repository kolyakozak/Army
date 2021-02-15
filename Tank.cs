using System;
using System.Collections.Generic;
using System.Text;

namespace Army
{
    class Tank: ITransport
    {
        public void Display()
        {
            Console.WriteLine("Tank - conducts land transportation and attacks");
        }
        public void Deliver(string forwObject)
        {
            Console.WriteLine($"Delivering the {forwObject} by land");
        }
        public void Attack(string target)
        {
            Console.WriteLine($"Attacking the {target} by land");
        }
    }
}
