using System;
using System.Collections.Generic;
using System.Text;

namespace Army
{
    class Therapist: Doctor
    {
        public override bool Examine(Man man)
        {
            int prob = 15;
            Random rnd = new Random();
            if(rnd.Next(100) < prob)
            {
                return false;
            }
            else if(nextHandler != null)
            {
                return nextHandler.Examine(man);
            }
            return true;
        }
    }
}
