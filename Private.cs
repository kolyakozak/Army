using System;
using System.Collections.Generic;
using System.Text;

namespace Army
{
    class Private: Rank
    {
        public Private(string fullname): base(fullname) { }
        public override void Display()
        {
            Console.WriteLine($"Info about Private {fullname}:");
        }
        public override void DrawStraps()
        {
            Console.WriteLine("Private's straps");
        }
        public override void ExecuteOrder(string command)
        {
            Console.WriteLine($"The private {fullname} performs {command}");
        }
    }
}
