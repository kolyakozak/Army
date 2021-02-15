using System;
using System.Collections.Generic;
using System.Text;

namespace Army
{
    class Traumatologist: Doctor
    {
        public override bool Examine(Man man)
        {
            int prob = 25;
            Random rnd = new Random();
            if (rnd.Next(100) < prob)
            {
                return false;
            }
            else if (nextHandler != null)
            {
                return nextHandler.Examine(man);
            }
            return true;
        }
    }
}
