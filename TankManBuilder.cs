using System;
using System.Collections.Generic;
using System.Text;

namespace Army
{
    class TankManBuilder: Builder
    {
        public override void Reset(Man man)
        {
            this.military = new Military(man.Fullname, man.Id);
            this.military.troopType = "TankMan";
        }
        public override void SetTransport()
        {
            this.military.transport = (new LandMachinary()).CreateTransport();
        }
        public override void SetEquipment()
        {
            this.military.equipment = "Undefined";
        }
        public override void SetWeapon()
        {
            this.military.weapon = new RealWeapon("Glock", 20, 30, 30);
        }
    }
}
