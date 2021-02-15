using System;
using System.Collections.Generic;
using System.Text;

namespace Army
{
    class SilencerDecorator: Decorator
    {
        public SilencerDecorator(Weapon wp): base(wp) { }

        public override void Display()
        {
            wp.Display();
            Console.WriteLine("Additional Gadget: Silencer");
        }
    }
}
