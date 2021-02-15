using System;
using System.Collections.Generic;
using System.Text;

namespace Army
{
    abstract class Rank
    {
        protected string fullname;

        public Rank(string fullname)
        {
            this.fullname = fullname;
        }
        public abstract void Display();
        public abstract void DrawStraps();
        public abstract void ExecuteOrder(string command);
    }
}
