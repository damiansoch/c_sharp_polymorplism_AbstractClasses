using System;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cube cube = new(12.54);
            cube.GetInfo();

            Sphere sphere = new(5.1);
            sphere.GetInfo();

            Console.WriteLine("\n");
            //or
            Shape[] shapes = { new Cube(1.54), new Sphere(47.1) };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"{shape.Name} volume: {shape.Volume()}");

                //as keyword
                //creating variable as a certain type
                Cube iceCube = shape as Cube;
                if(iceCube == null)
                {
                    Console.WriteLine("This shape is not a Cube");
                }

                if(shape is Cube)
                {
                    Console.WriteLine("This shape is a cube");
                }


            }
            Console.ReadLine();

            

            
        }
    }
}
