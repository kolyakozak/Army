using System;
using System.Collections.Generic;
using System.Text;

namespace Army
{
    class SightDecorator: Decorator
    {
        public SightDecorator(Weapon wp) : base(wp) { }

        public override void Display()
        {
            wp.Display();
            Console.WriteLine("Additional Gadget: Sight");
        }
    }
}
