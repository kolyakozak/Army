using System;
using System.Collections.Generic;
using System.Text;

namespace Army
{
    class AirMachinary: Machinary
    {
        public override ITransport CreateTransport()
        {
            return new Airplane();
        }
    }
}
