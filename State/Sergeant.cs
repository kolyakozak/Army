using System;
using System.Collections.Generic;
using System.Text;

namespace Army
{
    class Sergeant: Rank
    {
        public Sergeant(string fullname) : base(fullname) { }
        public override void Display()
        {
            Console.WriteLine($"Info about Sergeant {fullname}:");
        }
        public override void DrawStraps()
        {
            Console.WriteLine("Sergeant's straps");
        }
        public override void ExecuteOrder(string command)
        {
            Console.WriteLine($"The sergeant {fullname} performs {command}");
        }
    }
}
