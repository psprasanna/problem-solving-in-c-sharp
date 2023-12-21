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
            q24();
        }
        static int getInt(string message) 
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static double getDouble(string message) 
        {
            Console.Write(message);
            return double.Parse(Console.ReadLine());
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
        static void q16() 
        {
            //sum of natural numbers
            int n = getInt("Enter the value of N : ");
            Console.WriteLine("Sum of "+n+ " Natural numbers : "+(n*(n+1)/2));
        }
        static void q17() 
        {
            //get three numbers and find the average
            int n1 = getInt("Enter the first number : ");
            int n2 = getInt("Enter the Second number : ");
            int n3 = getInt("Enter the Third number : ");
            int total = n1+n2+n3;
            double average = total / 3;
            Console.WriteLine("Average is : "+average);
        }
        static void q18() 
        {
            //write a program to calculate the tip to be provided to the waiter, at 5% of bill amount
            double billAmount = getDouble("Enter the Bill Amount : ");
            double tip = billAmount * 5.0 / 100;
            Console.WriteLine("Tip : "+tip);
        }
        static void q19() 
        {
            //Given the total amount paid and the tax percentage, calculate the net amount of the product backwards.
            double totalAmount, taxPercentage, taxRate, netAmount;

            totalAmount = getDouble("Enter the Total Amount : ");
            taxPercentage = getDouble("Enter the Tax Percentage : ");
            taxRate = taxPercentage/100;
            netAmount = totalAmount/(1+taxRate);
            Console.WriteLine("Net Amount : "+netAmount);
            Console.WriteLine("Total Amount calculated by net amount : "+(netAmount+(netAmount*taxPercentage/100.0)));
        }
        static void q20() 
        {
            //Given the basic pay,DA% and TA%,PF%, calculate the grosspay.
            double basicPay, DaPercentage, TaPercentage, PfPercentage,grosspay,DaAmount,TaAmount,PfAmount;
            basicPay = getDouble("Enter the basic pay : ");
            DaPercentage = getDouble("Enter da Percentage : ");
            TaPercentage = getDouble("Enter ta Percentage : ");
            PfPercentage = getDouble("Enter pf Percentage : ");

            DaAmount = basicPay*DaPercentage/100;
            TaAmount = basicPay*TaPercentage/100;
            PfAmount = basicPay*PfPercentage/100;
            grosspay = (basicPay + DaAmount + TaAmount) - PfAmount;
            Console.WriteLine("Gross Pay : "+grosspay);
        }
        static void q21()
        {
            //write a program to calculate simple interest
            double p = getDouble("Enter the principal : ");
            double n = getDouble("Enter the N : ");
            double r = getDouble("Enter the r : ");
            Console.WriteLine("Simple Interest : "+(p*n*r/100));
        }
        static void q22() 
        {
            //write a program to compute compound interest
            double compoundInterest, p, n, r, t;
            p = getDouble("Enter the principal : ");
            n = getDouble("Enter the N : ");
            r = getDouble("Enter the r : ");
            int time = getInt("Enter the time in months :");
            t = time / 12.0;
            compoundInterest = p*(Math.Pow((1+r/n),(n*t)));
            Console.WriteLine("Compound Interest :"+compoundInterest);
        }
        static void q23() 
        {
            //given the height of a person in cm print the height in feet &inches.
            double height = getDouble("Enter the height in cm : ");
            double inches = height/2.4;
            double feet  = height*0.0328;
            Console.WriteLine("Inches : "+inches+"\nfeet : "+feet);
        }
        static void q24() 
        {
            //program to find BMI given height in meters and weight in kilograms.
            double height = getDouble("Enter the height in Meters : ");
            double weight = getDouble("Enter the weight in Kilograms : ");
            double bmi = weight / (height * height);
            Console.WriteLine("BMI : "+bmi);
        }
        static void q25()
        {
            //program to read roll no, name and marks of three subjects and calculate the total and average.
            int rollno = getInt("Enter the roll No : ");
            Console.Write("Enter the Name : ");
            string name = Console.ReadLine();
            int mark1 = getInt("Enter the First Mark : ");
            int mark2 = getInt("Enter the Second Mark : ");
            int mark3 = getInt("Enter the Third Mark : ");
            int total = mark1 + mark2 + mark3;
            double average = total / 3.0;
            Console.WriteLine("Roll No : \t{0}\nName : \t\t{1}\nTotal : \t{2}\nAverage : \t{3}",rollno,name,total,average);
        }
    }
}
