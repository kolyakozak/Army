using System;
using System.Collections.Generic;
using System.Text;

namespace Army
{
    class SniperBuilder: Builder
    {
        public override void Reset(Man man)
        {
            this.military = new Military(man.Fullname, man.Id);
            this.military.troopType = "Sniper";
        }
        public override void SetTransport()
        {
            this.military.transport = (new LandMachinary()).CreateTransport();
        }
        public override void SetEquipment()
        {
            this.military.equipment = "Binoculars";
        }
        public override void SetWeapon()
        {
            this.military.weapon = new RealWeapon("AWP", 10, 100, 100);
        }
    }
}
