using System;
using System.Collections.Generic;
using System.Text;

namespace Army
{
    abstract class Doctor
    {
        protected Doctor nextHandler = null;
        public abstract bool Examine(Man man);

        public void setNextHandler(Doctor next)
        {
            nextHandler = next;
        }
    }
}
