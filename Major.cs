using System;
using System.Collections.Generic;
using System.Text;

namespace Army
{
    class Major: Rank
    {
        public Major(string fullname) : base(fullname) { }
        public override void Display()
        {
            Console.WriteLine($"Info about Major {fullname}:");
        }
        public override void DrawStraps()
        {
            Console.WriteLine("Major's straps");
        }
        public override void ExecuteOrder(string command)
        {
            Console.WriteLine($"The major {fullname} performs {command}");
        }
    }
}
