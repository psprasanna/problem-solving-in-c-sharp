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
            q15();
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
        static void q6() 
        {
            //program to find the square of a given number
            int number = getInt("Enter the number to Find it Square : ");
            Console.WriteLine("Square of "+number+" is : "+(number*number));
        }
        static void q7() 
        {
            //program to find the square root of a given number
            int number = getInt("Enter the number to find its square root : ");
            Console.WriteLine("Square root of "+number+"is : "+Math.Sqrt(number));
        }
        static void q8() 
        {
            //program to calculate the area of triangle
            int breadth = getInt("Enter the Breadth  : ");
            int height = getInt("Enter the Height : ");
            Console.WriteLine("Area of Triangle is : "+(0.5*breadth*height));
        }
        static void q9() 
        {
            //program to convert kilometers to miles
            int kiloMeter = getInt("Enter the Kilo Meters : ");
            Console.WriteLine("Miles : "+(kiloMeter*0.621371));
        }
        static void q10() 
        {
            //program to convert celcius to fahrenheit
            int celcius = getInt("Enter the celcius : ");
            Console.WriteLine("Fahrenheit : "+((celcius*9/5)+32));
        }
        static void q11() 
        {
            //program to swap two variables
            int a = getInt("Enter the value of A : ");
            int b = getInt("Enter the value of B : ");
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("A is : "+a);
            Console.WriteLine("B is : " + b);
        }
        static void q12() 
        {
            //program to swap two variables without using temporary variables
            int a = getInt("Enter the value of A : ");
            int b = getInt("Enter the value of B : ");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("A is : " + a);
            Console.WriteLine("B is : " + b);
        }
        static void q13() 
        {
            //program to swap variables without causing overflow
            int a = getInt("Enter the value of A : ");
            int b = getInt("Enter the value of B : ");
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
            Console.WriteLine("A is : " + a);
            Console.WriteLine("B is : " + b);
        }
        static void q14() 
        {
            //generate random numbers between 1 to 100
            Random randomNumber = new Random();
            Console.WriteLine(randomNumber.Next(1,100));
        }
        static void q15() 
        {
            //Find the area of a field in acres, whose length and width are given in feet.
            double length = getInt("Enter the length : ");
            double width = getInt("Enter the width : ");
            double sqft = length * width;
            double acres = sqft / 43650;
            Console.WriteLine("Area of field in acres is : "+acres);
        }
    }
}
