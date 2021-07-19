using System;

namespace NumbersToWordsEN
{
    class Program
    {
        public static string NumbersToWords(int number)
        {
            while (number > 1000000)
            {
                Console.Write("Your number is bigger than 1000000. Please, enter another one to convert it to words: ");
                number = int.Parse(Console.ReadLine());
            }

            if (number == 0) return "zero";
            if (number < 0) return "minus " + NumbersToWords(Math.Abs(number));
            if (number == 1000000) return "one million";

            string words = "";

            if ((number / 1000) > 0)
            {
                words += NumbersToWords(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumbersToWords(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "") words += "and ";
                string[] numbersArr = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
                                                   "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
                string[] tensArr = new string[] { "zero", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                {
                    words += numbersArr[number];
                }
                else
                {
                    words += tensArr[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + numbersArr[number % 10];
                }
            }

            return words;

        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number (max - 1000000) to convert it to words: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(NumbersToWords(n));
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input.");
            }  
        }
    }
}
