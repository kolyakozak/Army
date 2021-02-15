using System;
using System.Collections.Generic;
using System.Text;

namespace Army
{
    abstract class Decorator: Weapon
    {
        protected Weapon wp;

        public Decorator(Weapon wp)
        {
            this.wp = wp;
        }

        public override void Display()
        {
            wp.Display();
        }
    }
}
