using System;
using System.Collections.Generic;
using System.Text;

namespace Army
{
    class MilitaryBase
    {
        public string title;
        private List<Military> militaries = new List<Military>();

        public MilitaryBase(string title)
        {
            this.title = title;
        }

        public void AddMilitary(Military military)
        {
            militaries.Add(military);
        }
        public void RemoveMilitary(int id)
        {
            foreach(Military mil in militaries)
            {
                if(mil.Id == id)
                {
                    militaries.Remove(mil);
                    break;
                }
            }
        }
        public Military GetMilitary(int id)
        {
            foreach (Military mil in militaries)
            {
                if (mil.Id == id)
                {
                    return mil;
                }
            }
            return null;
        }
        public void Display()
        {
            foreach(Military mil in militaries)
            {
                Console.WriteLine($"{mil.Fullname}({mil.Id}) - {mil.troopType}");
            }
        }
    }
}
