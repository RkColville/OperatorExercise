using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = (a / b);
            int remainder = (a % b);


            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);
            //Console.WriteLine(a % b);

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            Console.WriteLine();

            Console.WriteLine("Enter a number to calculate the area of a circle based on it's radius:");
            var r = double.Parse(Console.ReadLine());

            var pi = Math.PI;
            var areaOfCircle = pi * (r * r);
            Console.WriteLine($"The area of a circle with radius {r} is {areaOfCircle}");
        }
            
       
            
    }
}

