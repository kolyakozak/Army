using System;
using System.Collections.Generic;
using System.Text;

namespace Army
{
    abstract class ResidentalComponent
    {
        public string  name;
        protected int men_number;

        protected List<ResidentalComponent> children = new List<ResidentalComponent>();
        protected List<Man> men = new List<Man>();

        public ResidentalComponent(string name)
        {
            this.men_number = 0;
            this.name = name;
        }

        public abstract void AddChild(ResidentalComponent component);
        public abstract void RemoveChild(ResidentalComponent component);
        public abstract void AddMan(Man man, List<string> address);

        public abstract bool RemoveMan(int id);

        public abstract Man GetMan(int id);

        public void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name + " " + this.men_number.ToString());
            foreach(Man man in men)
            {
                Console.WriteLine(new String('-', depth) + man.Display());
            }
            
            foreach (ResidentalComponent component in children)
                component.Display(depth + 2);
        }

        public virtual void Conscription()
        {
            for(int i = 0; i < men.Count; i++)
            {
                men[i].RespondConscription();
            }
            foreach (ResidentalComponent component in children)
            {
                component.Conscription();
            }
        }
    }
}
