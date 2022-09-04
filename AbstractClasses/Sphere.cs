using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Sphere : Shape
    {
        public double Radius { get; set; }

        public Sphere(double radius)
        {
            Name = "Sphere";
            Radius = radius;
        }   

        public override double Volume()
        {
            return (4 * Math.PI * (Math.Pow(Radius,3)))/3;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"\n This is a {Name}, and has a volume of {Volume()}");
        }
    }
}
