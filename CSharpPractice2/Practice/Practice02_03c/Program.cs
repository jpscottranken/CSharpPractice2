using System;
using static System.Console;

/*
 *  Extra 5-2 Calculate change
 *  ==========================
 *  In this exercise, you'll develop a form 
 *  that tells how many quarters, dimes, nickels, 
 *  and pennies are needed to make change for 
 *  any amount of change from 1 through 99 cents.
 *  
 *  One way to get the results is to use the
 *  division and modulus operators and to cast 
 *  the result of each division to an integer.
 *  
 *  1.	GUI Only:
 *		Create an event handler for the Click event 
 *		of the Calculate button. Then, write the code 
 *		for calculating and displaying the number of 
 *		quarters, dimes, nickels, and pennies that 
 *		are needed for the change amount a user enters.
 *		
 *		This code should provide for integer entries, 
 *		but you can assume that the user will enter 
 *		valid integer values.
 *		
 *		GUI Only:
 *	2.	Create an event handler for the Click event 
 *	    of the Exit button that closes the form.
 *	    
 *	3.  Test the app to be sure it works correctly.
 */

namespace Console
{
    internal class Program
    {
        //  Declare and initialize program constants
        const int MINNUMBER     = 1;
        const int MAXNUMBER     = 99;
        const int QUARTERVALUE  = 25;
        const int DIMEVALUE     = 10;
        const int NICKELVALUE   = 5;

        //  Declare and initialize class variable
        static int number = 0;

        static void Main(string[] args)
        {
            while (1 == 1)
            {
                InputNumber();
                CalculateChangeNumbers();
            }
		}

        static void InputNumber()
        {
            Clear();

            bool result;

            Write($"Enter a number between {MINNUMBER} and {MAXNUMBER}:\t");
            string numberStr = ReadLine();

            //  Check for no input
            if ( numberStr == "" )
            {
                WriteLine("You Must Enter A Number. Try Again.");
                ReadLine();
                InputNumber();
            }

            //  We had input.
            //  Make sure input is valid
            result = int.TryParse(numberStr, out number );

            if (!result             ||
                number < MINNUMBER  ||
                number > MAXNUMBER)
            {
                WriteLine("Invalid Input. Try Again.");
                ReadLine();
                InputNumber();
            }
        }

        static void CalculateChangeNumbers()
        {
            int numQuarters = 0;
            int numDimes   = 0;
            int numNickels = 0;
            int numPennies = 0;
            int whatsLeft = 0;

            numQuarters = number / QUARTERVALUE;
            whatsLeft   = number % QUARTERVALUE;

            numDimes =  whatsLeft / DIMEVALUE;
            whatsLeft = whatsLeft % DIMEVALUE;

            numNickels = whatsLeft / NICKELVALUE;
            numPennies = whatsLeft % NICKELVALUE;

            WriteLine($"\n\nNumber Input:\t\t{number}");
            WriteLine($"Number Quarters:\t{numQuarters}");
            WriteLine($"Number Dimes:\t\t{numDimes}");
            WriteLine($"Number Nickels:\t\t{numNickels}");
            WriteLine($"Number Pennies:\t\t{numPennies}");

            ReadLine();
        }
    }
}
