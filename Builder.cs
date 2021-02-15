using System;
using System.Collections.Generic;
using System.Text;

namespace Army
{
    abstract class Builder
    {
        protected Military military;


        public abstract void Reset(Man man);
        public abstract void SetTransport();
        public abstract void SetEquipment();
        public abstract void SetWeapon();

        public Military GetResult()
        {
            return military;
        }
    }
}
