using System;
using System.Collections.Generic;
using System.Text;

namespace Army
{
    class Colonel: Rank
    {
        public Colonel(string fullname) : base(fullname) { }
        public override void Display()
        {
            Console.WriteLine($"Info about Colonel {fullname}:");
        }
        public override void DrawStraps()
        {
            Console.WriteLine("Colonel's straps");
        }
        public override void ExecuteOrder(string command)
        {
            Console.WriteLine($"The colonel {fullname} performs {command}");
        }
    }
}
