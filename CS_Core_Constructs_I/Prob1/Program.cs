/*
Author: Richard Mora
Date:   10/05/2019
CTEC 135: Microsoft Software Development with C#

Module 2, Programming Assignment 1, Problem 1

    Variables and Printing

Region 1: variable declaration. Declare three different double variables using each of the three type declarations.

Region 2:variable initialization. Declare separate variables for each numeric type that is CLS compliant and initialize it to some nonzero value.

Region 3: Max/Min values. Print out the min and max values of different types to the terminal screen. Use descriptive text.

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region variable declarations 
                // Here we declare a variable using the 'double' type using three different type of methods.
                // The first way to declare double is the most used, starting with double keyword, follow by the name you want it to be and the value 135.
                double FirstNumber = 135;
                // The second way to declare double is using System.Double to declare the number 121 to SecondNumber
                System.Double SecondNumber = 121;
                // The third way uses the 'new' keyword to create a new double type for the variable ThirdNumber
                double ThirdNumber = new double();
                // Since we already declared ThirdNumber as a type 'double' we can assign it to the integer 165.
                ThirdNumber = 165;
            #endregion

            #region variable initialization
                // Here I declare mulitple variable that are CLS compliant and assign them each a non-zero value
                bool MyBool = true;
                byte MyByte = 64;
                short MyShort = 10_000;
                int MyInt = 1_000_000;
                long MyLong = 123_456_789;
                char MyChar = '9';
                float MyFloat = 3_659;
                double MyDouble = 365;
                decimal MyDecimal = 3.912_1M;
                string MyString = "CTEC";
                object MyObject = 135;

                // Here we use Console.WriteLine() to display some text and the value of each data type defined above
                Console.WriteLine(@"First Vaiable Type 'bool' value is: {0}", MyBool);
                Console.WriteLine(@"Second Variable Type 'byte' value is: {0:d4}", MyByte);
                Console.WriteLine(@"Third Variable Type 'short' value is: {0:n}", MyShort);
                Console.WriteLine(@"Fourth Variable Type 'int' value is: {0:c}", MyInt);
                Console.WriteLine(@"Fifth Variable Type 'long' value is: {0:c}", MyLong);
                Console.WriteLine(@"Sixth Variable Type 'char' value is {0}", MyChar);
                Console.WriteLine(@"Seventh Variable Type 'float' value is: {0:f3}", MyFloat);
                Console.WriteLine(@"Eighth Variable Type 'double' value is: {0}", MyDouble);
                Console.WriteLine(@"Ninth Variable Type 'decimal' value is: {0}", MyDecimal);
                Console.WriteLine(@"Tenth Variable Type 'string' value is: {0}", MyString);
                Console.WriteLine(@"Last Variable Type 'object' value is: {0}", MyObject);
            #endregion

            #region Max/Min values

                // For the next two lines, I use Console.WriteLine() to display some text and use MaxValue and MinValue to find the max and min value of the data type 'float'
                Console.WriteLine("The max value of the data type \'float\' is: {0}", float.MaxValue);
                Console.WriteLine("The min value of the data type \'float\' is: {0}", float.MinValue);
            #endregion
        }
    }
}
