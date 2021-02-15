using System;
using System.Collections.Generic;
using System.Text;

namespace Army
{
    class RealMan: Man
    {

        public RealMan(string fullname)
        {
            id = DataBase.next_man_id++;
            this.fullname = fullname;
        }
        public override void RespondConscription()
        {
            Random rnd = new Random();
            int prob = rnd.Next(1, 5);
            switch(prob)
            {
                case 1: this.GoToArmy(DataBase.sniperBuilder); break;
                case 2: this.GoToArmy(DataBase.marineBuilder); break;
                case 3: this.GoToArmy(DataBase.tankManBuilder); break;
                case 4: this.GoToArmy(DataBase.pilotBuilder); break;
            }
        }
    }
}
