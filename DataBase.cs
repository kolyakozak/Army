using System;
using System.Collections.Generic;
using System.Text;

namespace Army
{
    static class DataBase
    {
        public static int next_man_id = 0;
        public static ResidentalComponent ukraine = new Composite("Ukraine");
        public static Doctor doctor = new Therapist();
        public static SniperBuilder sniperBuilder = new SniperBuilder();
        public static PilotBuilder pilotBuilder = new PilotBuilder();
        public static TankManBuilder tankManBuilder = new TankManBuilder();
        public static MarineBuilder marineBuilder = new MarineBuilder();
        public static MilitaryBase militaryBase = new MilitaryBase("MainBase");
    }
}
