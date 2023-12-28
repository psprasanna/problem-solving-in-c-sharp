using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set2
{
    class Program  // conditionals
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
            //program to check if a Number is Positive,Negative or 0.
            int n = getInt("Enter N : ");
            if (n > 0) 
            {
                Console.WriteLine("The value "+n+" is Positive");
            }
            else if (n < 0) 
            {
                Console.WriteLine("The value " + n + " is Negative");
            }
            else if (n == 0) 
            {
                Console.WriteLine("The value " + n + " is zero");
            }
        }
        static void q2() 
        {
            //check if two integers are equal or not.
            int n1 = getInt("Enter first number : ");
            int n2 = getInt("Enter the second number : ");
            if (n1 == n2)
            {
                Console.WriteLine("Equal");
            }
            else if(n1 != n2)
            {
                Console.WriteLine("Not Equal");
            }
        }
        static void q3() 
        {
            //check if two floating point numbers are equal or not
            Console.WriteLine("Enter first number : ");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number : ");
            float n2 = float.Parse(Console.ReadLine());
            if (n1 == n2)
            {
                Console.WriteLine("Equal");
            }
            else if (n1 != n2)
            {
                Console.WriteLine("Not Equal");
            }
        }
        static void q4() 
        {
            //program to check if a number is odd or even
            int n = getInt("Enter N : ");
            if (n % 2 == 0) 
            {
                Console.WriteLine(n+" is an Even Number");
            }
            else if (n % 2 != 0) 
            {
                Console.WriteLine(n+" is a odd number");
            }
        }
        static void q5() 
        {
            //Program to check Leap Year
            int year = getInt("Enter the year : ");
            if (year % 100 == 0) 
            {
                if (year % 400 == 0)
                {
                    Console.WriteLine("It is leap year");
                }
                else 
                {
                    Console.WriteLine("It is not a leap year");
                }
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine(" It is a leap year ");
            }
            else 
            {
                Console.WriteLine("It is not a leap year");
            }
        }
    }
}
