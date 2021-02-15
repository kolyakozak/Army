using System;
using System.Collections.Generic;
using System.Text;

namespace Army
{
    interface ITransport
    {
        public void Display();
        public void Deliver(string forwObject);
        public void Attack(string target);
    }
}
