using System;
using System.Collections.Generic;
using System.Text;

namespace Army
{
    class Military: Rank
    {
        private int id;
        public virtual int Id
        {
            get { return id; }
        }
        public virtual string Fullname
        {
            get { return fullname; }
        }

        public string troopType;
        public Weapon weapon;
        public ITransport transport;
        public string equipment;

        private Rank rank;

        public Military(string fullname, int id): base(fullname)
        {
            this.id = id;
            this.rank = new Private(fullname);
        }
        public override void Display()
        {
            rank.Display();
            Console.WriteLine($"Type of troop: {troopType}");
            Console.WriteLine($"Equipment: {equipment}");
            transport.Display();
            weapon.Display();
        }
        public override void DrawStraps()
        {
            rank.DrawStraps();
        }
        public override void ExecuteOrder(string command)
        {
            rank.ExecuteOrder(command);
        }
        public void ChangeRank(Rank rank)
        {
            this.rank = rank;
        }
    }
}
