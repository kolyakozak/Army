using System;
using System.Collections.Generic;
using System.Text;

namespace Army
{
    class MarineBuilder: Builder
    {
        public override void Reset(Man man)
        {
            this.military = new Military(man.Fullname, man.Id);
            this.military.troopType = "Marine";
        }
        public override void SetTransport()
        {
            this.military.transport = (new LandMachinary()).CreateTransport();
        }
        public override void SetEquipment()
        {
            this.military.equipment = "Parachute";
        }
        public override void SetWeapon()
        {
            this.military.weapon = new RealWeapon("AK-47", 30, 70, 80);
        }
    }
}
