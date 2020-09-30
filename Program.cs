using System;

namespace Chapter2Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double radius = -1;
            double gallonsOfGas;
            string mpg;
            double mpgDouble = -1;

            Console.WriteLine("Enter a radius: ");
            input = Console.ReadLine();
            try
            {
                radius = double.Parse(input);
            }
            catch
            {
                Console.WriteLine("Invalid Entry!");
                Environment.Exit(0);
            }
            
            while(radius <= 0)
            {
                Console.WriteLine("Enter a radius: ");
                input = Console.ReadLine();
                radius = double.Parse(input);
            }

            Console.WriteLine("The area of a circle of radius " + radius + " is: " + Math.Round(Circle.areaOfCircle(radius),3));

            Console.WriteLine("The diamater of a circle of radius " + radius + " is: " + Math.Round(Circle.getDiameter(radius),3));

            Console.WriteLine("What is the MPG of your car?");
            mpg = Console.ReadLine();
            try
            {
                mpgDouble = double.Parse(mpg);
                if(mpgDouble <= 0)
                {
                    Console.WriteLine("Invalid Entry!");
                    Environment.Exit(0);
                }
            }
            catch 
            {
                Console.WriteLine("Invalid Entry!");
                Environment.Exit(0);
            }

            gallonsOfGas = Circle.getCircumference(radius) / mpgDouble;

            Console.WriteLine("Gallons of gas used to go around the circle " + Math.Round(gallonsOfGas,3));
        }
    }
}
