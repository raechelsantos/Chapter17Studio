using System;

namespace Chapter17Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi. To calculate the area of a circle, please enter a radius:");
            string radiusInput = Console.ReadLine();
            double radius = Double.Parse(radiusInput);
            double areaCir = (3.14 * radius * radius);
            Console.WriteLine($"\nThe area of a circle of radius {radius} is: {areaCir}");

            // 17.3.2.2 Road Trip!
            Console.WriteLine("\nFor fun, let's calculate how many gallons it would take to drive around the circumference of the aforementioned circle.\nHow many miles do you get per gallon from your vehicle?\nPlease enter the number of miles only (e.g. 27).\n");
            string mpgInput = Console.ReadLine();
            double mpg = Double.Parse(mpgInput);
            double circumference = (2 * 3.14 * radius);
            double gallonsForTravel = circumference / mpg;
            Console.WriteLine($"\nTo travel around the circle with your vehicle, you need {gallonsForTravel} gallons of fuel.");

        }
    }
}
