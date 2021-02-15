using System;
using System.Collections.Generic;
using System.Text;

namespace Army
{
    class LandMachinary: Machinary
    {
        public override ITransport CreateTransport()
        {
            return new Tank();
        }
    }
}
