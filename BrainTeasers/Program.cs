using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyConsole;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            var menu = new EasyConsole.Menu()
                .Add("Sum Even Numbers in an array - For loop", () =>  sumEvenNumbersInAnArray())
                .Add("Sum Numbers in an array - Extension method", () => ConvertArrayToListAndSumWithExtensionMethod())
                .Add("Check if string is a palindrome", () => CheckIfPalindrome())
                .Add("Exit", () => Environment.Exit(0));
            
            menu.Display();


            //ConvertArrayToListAndSumWithExtensionMethod();
            //Environment.Exit(0);
            //
            //sumEvenNumbersInAnArray();
            //
            //SumDigitsInANumber();
            //
            //
            //int num, sum = 0, r;
            //Console.WriteLine("Enter a number: ");
            //num = int.Parse(Console.ReadLine());
            //Console.WriteLine(num);
            //while (num != 0)
            //{
            //    r = num % 10;
            //    sum = sum + r;
            //    num /= 10 ;
            //
            //}
            //Console.WriteLine("Sum of the digits: {0}", sum);
            Console.WriteLine("Press and key to continue...");
            Console.ReadLine();

        }

        static void SumDigitsInANumber()
        {
            int x = 10;
            int y = 2;
            
            //912 267 6195

            int j = x + y;
            Console.WriteLine("The sum of {0}+{1}={2}", x, y, j);
            //Console.WriteLine("Press and key to continue...");
            //Console.ReadLine();

        }

        static void sumEvenNumbersInAnArray()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sum = 0;

            string location;
            DateTime time;


            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }

            int sum2 = numbers.Where(i => i % 2 == 0).Sum(i => i);
            Console.WriteLine("Sum of even digits: {0}", sum);
            //Console.WriteLine("Press and key to continue...");
            //Console.ReadLine();

        }

        static void ConvertArrayToListAndSumWithExtensionMethod()
        {
            int[] array1 = { 1, 3, 5, 7 };
            List<int> list1 = array1.ToList();

            int sum1 = array1.Sum();
            int sum2 = list1.Sum();


            Console.WriteLine(sum1);
            //Console.WriteLine(sum2);
        }

        static void CheckIfPalindrome()
        {
            Console.Write("Enter string: ");

            string str = Console.ReadLine();

            Console.WriteLine(str.SequenceEqual(str.Reverse()));

        }
    }
}
