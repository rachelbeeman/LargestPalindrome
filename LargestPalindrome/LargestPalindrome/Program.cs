/*  Rowan Beeman
   
  LargestPalindrome
  From https://projecteuler.net/problem=4
  
  A palindromic number reads the same both ways. 
  The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
  Find the largest palindrome made from the product of two 3-digit numbers.

  [Output should be 906609.]
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int HighestPalindromeFound = 0;
            int successfulX = 0;
            int successfulY = 0;

            //Find the largest palindrome product of 2 3 digit numbers
            //Start with the largest 3 digit numbers
            int x = 999;
            int y = 999;

            //Decrement through x and y, checking each pair for a palindrome. 
            for (; x > 99; x--)
            {
                y = 999;
                for (; y > 99; y--)
                {
                    //If a palindrome is found, check to see if it is higher or lower than the current saved palindrome.
                    if (IsAProductPalindrome(x, y))
                        if (x * y > HighestPalindromeFound)
                        {
                            HighestPalindromeFound = x * y;
                            successfulX = x;
                            successfulY = y;
                        }
                }
            }

            Console.WriteLine("The highest palindrome product of 2 3 digit numbers is: ");
            Console.WriteLine(successfulX + " * " + successfulY + " = " + HighestPalindromeFound);
            Console.ReadLine();
        }

        //This function takes two integer numbers and checks to see if their product is a palindrome number.
        private static bool IsAProductPalindrome(int num1, int num2)
        {
            int testNumber = num1 * num2;
            String testNumberString = testNumber.ToString();

            var a = (testNumberString.ToArray<char>());
            Array.Reverse(a);

            String testNumberStringReverse = new string(a);

            if (testNumberString.Equals(testNumberStringReverse))
            {
                return true;
            }

            return false;
        }
    }
}
