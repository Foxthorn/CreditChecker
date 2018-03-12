using System;

namespace CreditChecker
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter a credit card number: ");
            string creditCardNumber = Console.ReadLine().Trim();
            int[] doubledNumbers = new int[creditCardNumber.Length / 2];
            int addition = 0;
            int doubleCounter = 0;
            for (int i = creditCardNumber.Length - 1; i >= 0; i--)
            {
                if (i % 2 == 0)
                {
                    doubledNumbers[doubleCounter] = DoubleNumbers((creditCardNumber[i]));
                    doubleCounter++;
                }
            }
            doubleCounter = 0;
            for (int i = 0; i < creditCardNumber.Length; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                addition = addition + AddNumbers(creditCardNumber[i], doubledNumbers[doubleCounter]);
                doubleCounter++;
            }
            if (addition % 10 == 0)
            {
                Console.Write("Valid");
            }
            else
            {
                Console.Write("Invalid");
            }
            Console.ReadLine();
        }

        private static int AddNumbers(char char1, int num2)
        {
            int num1 = (int)Char.GetNumericValue(char1);
            if (num1 >= 10)
            {
                num1 = 1 + (num1 % 10);
            }
            if (num2 >= 10)
            {
                num2 = 1 + (num2 % 10);
            }
            return num1 + num2;
        }

        private static int DoubleNumbers(char num)
        {
            string stringNum = Convert.ToString(num);
            int number = Convert.ToInt32(stringNum);
            number = number * 2;
            return number;
        }
    }
}