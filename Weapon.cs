using System;
using System.Collections.Generic;
using System.Text;

namespace Army
{
    abstract class Weapon
    {
        protected string title;
        protected int accuracy;
        protected int maxAmmunition;
        protected int noisiness;

        public abstract void Display();

    }
}
