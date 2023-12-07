using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set1
{
    class Program
    {
        static void Main(string[] args)
        {
            q5();
        }
        static int getInt(string message) 
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static void q1()
        {
            //Given two integers, write a program to display the sum, difference, and their product.
            Console.Write("Enter First Number : ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Second Number : ");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum of Two Numbers : " + (number1 + number2) + "\nDifference of Two Numbers : " + Math.Abs(number1 - number2) +             "\nProduct of Two Numbers : " + (number1 * number2));
        }
        static void q2() 
        {
            //write a program to find the value of a raised to the power of b, where a & b are positive integers.
            int a = getInt("Enter the value of A : ");
            int b = getInt("Enter the value of B : ");
            Console.WriteLine("Power value is : "+Math.Pow(a,b));
        }
        static void q3() 
        {
            //write a program to find the volume of rectangular water tank.
            int length = getInt("Enter the length : ");
            int breadth = getInt("Enter the breadth :");
            int height = getInt("Enter the height : ");
            int volume = length * breadth * height;
            Console.WriteLine("volume of Rectangular is : "+volume);
        }
        static void q4() 
        {
            //Find the perimeter of a circle given the radius
            int radius = getInt("Enter the radius : ");
            Console.WriteLine("Perimeter of the circle is : "+(2*Math.PI*radius));
        }
        static void q5() 
        {
            //Given a numerator and denominator, find the quotient and remainder.
            int numerator = getInt("Enter the numerator : ");
            int denominator = getInt("Enter the denominator : ");
            int quotient = numerator / denominator;
            int remainder = numerator % denominator;
            Console.WriteLine("quotient : " + quotient + "\nremainder : " + remainder);
        }
    }
}
