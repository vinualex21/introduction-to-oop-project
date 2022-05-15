using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro2oop
{
    public class Parrot : Bird
    {
        public Parrot(string name, string color) : base(name, color)
        {
        }

        public override void Speak()
        {
            Console.WriteLine($"Hi! I'm a {Color} {Name} and I love repeating what i hear.");
        }

        
    }
}
