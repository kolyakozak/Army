using System;
using System.Collections.Generic;
using System.Text;

namespace Army
{
    abstract class Man
    {
        protected int id;
        protected string fullname;

        public virtual int Id
        {
            get { return id; }
        }
        public virtual string Fullname
        {
            get { return fullname; }
        }
        public abstract void RespondConscription();

        public void GoToArmy(Builder builder)
        {
            builder.Reset(this);
            Director.createMilitary(builder);
            Military mil = builder.GetResult();
            DataBase.militaryBase.AddMilitary(mil);
            DataBase.ukraine.RemoveMan(Id);
        }
        public virtual string Display()
        {
            return $"{Fullname}({Id})";
        }
    }
}
