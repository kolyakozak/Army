using System;
using System.Collections.Generic;
using System.Text;

namespace Army
{
    static class Director
    {
        public static void createMilitary(Builder builder)
        {
            builder.SetEquipment();
            builder.SetWeapon();
            builder.SetTransport();
        }
    }
}
