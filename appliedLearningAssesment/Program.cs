using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appliedLearningAssesment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Number 1. Create program that asks user to enter an Int.

            Console.WriteLine("Enter a Number: ");  //Ask User to Enter an Integer
            int userNum = int.Parse(Console.ReadLine()); // Declare User Number variable and assign to user's input

            if (userNum < 10)   // begin if else with less than conditional
            {
                Console.WriteLine("This number is too small."); //print wrong message
            }

            else   
            {
                Console.WriteLine("This number is big enough."); //print right message
            }




            //Number 2. Create a program that creates an array

            double[] hardCode = { 2.16, 3.14, 4.04, 6.0, 30.0 };    //declare and assign double array 

            Console.WriteLine(hardCode[1]); //print second index of array



            //Number 3. Modify #2 to use foreach loop

            double[] hardCode3 = { 2.16, 3.14, 4.04, 6.0, 30.0 };   //declare and assign double array

            foreach (double code in hardCode3) //start foreach loop
            {
                Console.Write(code + " ");      //print contents of array on one line
            }


            //Number 4. Write a program that asks user to enter an integer using switch case

            Console.WriteLine("Enter a Number: ");      //ask user to enter number
            int userInput = int.Parse(Console.ReadLine());          //declare, assign user input and convert from string to integer

            switch (userInput)  //start switch case
            {
                case 1:         //case 1
                    Console.WriteLine("Only one?");       //print case 1 message
                    break;      //end case 1

                case 100:       //case 100
                    Console.WriteLine("100? That's a lot!");        //print case 100 message
                    break;      //end case 100

                default:        //else case
                    Console.WriteLine("Input not recognized.");     //print error message
                    break;          //end default case
            }



        }
    }
}
