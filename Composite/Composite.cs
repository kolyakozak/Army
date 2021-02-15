using System;
using System.Collections.Generic;
using System.Text;

namespace Army
{
    class Composite: ResidentalComponent
    {

        public Composite(string name): base(name) { }

        public override void AddChild(ResidentalComponent component)
        {
            children.Add(component);
        }
        public override void RemoveChild(ResidentalComponent component)
        {
            children.Remove(component);
        }
        public override void AddMan(Man man, List<string> address)
        {
            if (address.Count != 0)
            {
                string elem = address[0];
                address.RemoveAt(0);
                ResidentalComponent next = children.Find(x => x.name == elem);
                if (next == null)
                {
                    next = new Composite(elem);
                    children.Add(next);
                }
                next.AddMan(man, address);
            }
            else
            {
                men.Add(man);
            }
            men_number += 1;
        }
        public override bool RemoveMan(int id)
        {

            foreach (Man man in men)
            {
                if (man.Id == id)
                {
                    men.Remove(man);
                    men_number -= 1;
                    return true;
                }
            }

            foreach (ResidentalComponent com in children)
            {
                if (com.RemoveMan(id))
                {
                    men_number -= 1;
                    return true;
                }
            }
            return false;
        }
        public override Man GetMan(int id)
        {
            foreach (Man man in men)
            {
                if (man.Id == id)
                {
                    return man;
                }
            }

            foreach (ResidentalComponent com in children)
            {
                Man man = com.GetMan(id);
                if (man != null) return man;
            }
            return null;
        }
    }
}
