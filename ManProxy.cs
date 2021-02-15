using System;
using System.Collections.Generic;
using System.Text;

namespace Army
{
    class ManProxy: Man
    {
        private RealMan man;
        private bool isUnfit = false;
        public ManProxy(string fullname)
        {
            man = new RealMan(fullname);
        }
        public override int Id
        {
            get { return man.Id; }
        }
        public override string Fullname
        {
            get { return man.Fullname; }
        }

        public override void RespondConscription()
        {
            if (isUnfit) return;
            if(DataBase.doctor.Examine(this))
            {
                man.RespondConscription();
            }
            else
            {
                isUnfit = true;
            }
        }
        public override string Display() 
        {
            string healthy = isUnfit ? " - Unfit" : "";
            return $"{Fullname}({Id})" + healthy;
        }
    }
}
