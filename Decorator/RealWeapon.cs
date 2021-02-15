using System;
using System.Collections.Generic;
using System.Text;

namespace Army
{
    class RealWeapon: Weapon
    {

        public RealWeapon(string title, int ammo, int acc, int nois)
        {
            this.title = title;
            accuracy = acc;
            maxAmmunition = ammo;
            noisiness = nois;
        }
        public override void Display()
        {
            Console.WriteLine($"Info about weapon: {title}");
            Console.WriteLine($"MaxAmmunition: {maxAmmunition}");
            Console.WriteLine($"Accuracy: {accuracy}");
            Console.WriteLine($"Noisiness: {noisiness}");
        }
    }
}
