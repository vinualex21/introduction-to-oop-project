﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro2oop
{
    public class Pigeon : Bird
    {
        //The Pigeon constructor calls the base class Bird constructor
        //The name and color parameters are passed to the Bird constructor
        public Pigeon(string name, string color) : base(name, color)
        {
        }

        public override void Speak()
        {
            Console.WriteLine($"Yo! I'm {Name} and I'm a {Color} pigeon.");
        }

        public void EatPizza()
        {
            Console.WriteLine("Delicious pizza!");
        }

        public void Sleep()
        {
            Console.WriteLine("I'm a sleeping pigeon");
        }
    }
}
