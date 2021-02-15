using System;
using System.Collections.Generic;
using System.Text;

namespace Army
{
    class PilotBuilder: Builder
    {

        public override void Reset(Man man)
        {
            this.military = new Military(man.Fullname, man.Id);
            this.military.troopType = "Pilot";
        }
        public override void SetTransport()
        {
            this.military.transport = (new AirMachinary()).CreateTransport();
        }
        public override void SetEquipment()
        {
            this.military.equipment = "Parachute, Oxygen cylinder";
        }
        public override void SetWeapon()
        {
            this.military.weapon = new RealWeapon("USP-S", 12, 50, 20);
        }
    }
}
