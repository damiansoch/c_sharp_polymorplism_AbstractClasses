﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Cube : Shape
    {

        public double Lenght { get; set; }

        public Cube(double lenght)
        {
            Name = "Cube";
            Lenght = lenght;
        }

        public override double Volume()
        {
            return Math.Pow(Lenght, 3);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"\n The {Name} has a volume of: {Volume()}");
        }
    }
}
