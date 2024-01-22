﻿using System;
using static System.Console;

/*
 *  Extra 5-3 Calculate income tax
 *  ==============================
 *  In this exercise, you'll use nested if 
 *  statements and arithmetic expressions 
 *  to calculate the federal income tax that 
 *  is owed for a taxable income amount 
 *  entered by the user.
 *  
 *  This is the 2023 table for the federal 
 *  income tax on individuals that you should 
 *  use for calculating the tax:
 *  
 *			Taxable income				Income tax
 *  Over…			But not over…						Of excess over…
 *  $0					$11,000			$0 plus 10%				$0
 *  $11,000				$44,725			$1,100.00 plus 12%		$11,000
 *  $44,725				$95,375			$5,147.00 plus 22%		$44,725
 *  $95,375				$182,100		$16,290.00 plus 24%		$95,375
 *  $182,100			$231,250		$37,104.00 plus 32%		$182,100
 *  $231,250			$578,125		$52,832.00 plus 35%		$231,250
 *  $578,125							$174,238.25 plus 37%	$578,125
 *  
 *  1.	GUI Only:
 *		Create an event handler for the Click 
 *		event of the Exit button that closes 
 *		the form.
 *		
 *	2.	Create an event handler for the Click 
 *		event of the Calculate button. Then, 
 *		write the code for calculating and
 *		displaying the tax owed for any amount 
 *		within the first two brackets in the 
 *		table above. 
 *		
 *		This code should provide for decimal
 *		entries, but you can assume that the 
 *		user will enter valid decimal values. 
 *		
 *		To test this code, use income values 
 *		of 8700 and 35150, which should 
 *		display taxable amounts of 870 and 3998.
 *		
 *	3.  Add the code for the next tax bracket. 
 *	    Then, add the code for the remaining 
 *	    tax brackets.
 */

namespace Practice02_04c
{
    internal class Program
    {
        //  Declare and initialize class variable
        static decimal income = 0m;
        static void Main(string[] args)
        {
            while (1 == 1)
            {
                InputIncome();
                CalculateTaxDue();
            }
        }

        static void InputIncome()
        {
            Clear();
            bool result;

            Write("Enter an income:\t");
            string incomeStr = ReadLine();

            //  Check for no input
            if (incomeStr.Trim() == "")
            {
                WriteLine("You Must Input A Number. Try Again.");
                ReadLine();
                InputIncome();
            }

            //  There was input. Validate input
            result = decimal.TryParse(incomeStr, out income);
            if (!result ||
                income <= 0)
            {
                WriteLine("Non-Numeric or OOR Input. Try Again.");
                ReadLine();
                InputIncome();
            }
        }

        static void CalculateTaxDue()
        {
            decimal taxDue = 0.00m;

            if (income >= 578125)
            {
                taxDue = 174238.25m + ((income - 578125m) * 0.37m);
            }
            else if (income >= 231250)
            {
                taxDue = 52832.00m + ((income - 231250m) * 0.35m);
            }
            else if (income >= 182100)
            {
                taxDue = 37104.00m + ((income - 182100) * 0.32m);
            }
            else if (income >= 95375)
            {
                taxDue = 16290.00m + ((income - 95375) * 0.24m);
            }
            else if (income >= 44725)
            {
                taxDue = 5147.00m + ((income - 44725) * 0.22m);
            }
            else if (income >= 11000)
            {
                taxDue = 1100.00m + ((income - 11000) * 0.12m);
            }
            else if (income > 0)
            {
                taxDue = 0.00m + (income * 0.10m);
            }

            WriteLine($"Income:\t\t\t{income:c}");
            WriteLine($"Tax Due:\t\t{taxDue:c}");

            ReadLine();
        }
    }
}
