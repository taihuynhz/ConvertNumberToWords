using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertNumberToWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter digits: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 0)
            {
                Console.Write("out of ability ");
            }
            else if (num > 10 && num < 20)
            {
                teens(num);
            }
            else
            {
                ones_tens_hundreds(num);
            }
        }

        static void ones_tens_hundreds(int num)
        {
            switch ((num / 100) % 10)
            {
                case 1: Console.Write("One hundred and "); break;
                case 2: Console.Write("Two hundred and "); break;
                case 3: Console.Write("Three hundred and "); break;
                case 4: Console.Write("Four hundred and "); break;
                case 5: Console.Write("Five hundred and "); break;
                case 6: Console.Write("Six hundred and "); break;
                case 7: Console.Write("Seven hundred and "); break;
                case 8: Console.Write("Eight hundred and "); break;
                case 9: Console.Write("Nine hundred and "); break;
            }
            if (num % 100 > 10 && num % 100 < 20)
            {
                switch (num % 100)
                {
                    case 10: Console.Write("Ten "); break;
                    case 11: Console.Write("Eleven "); break;
                    case 12: Console.Write("Twelve "); break;
                    case 13: Console.Write("Thirteen "); break;
                    case 14: Console.Write("Fourteen "); break;
                    case 15: Console.Write("Fifteen "); break;
                    case 16: Console.Write("Sixteen "); break;
                    case 17: Console.Write("Seventeen "); break;
                    case 18: Console.Write("Eighteen "); break;
                    case 19: Console.Write("Nineteen "); break;
                }
            }
            else
            {
                switch ((num / 10) % 10)
                {
                    case 1: Console.Write("Ten "); break;
                    case 2: Console.Write("Twenty "); break;
                    case 3: Console.Write("Thirty "); break;
                    case 4: Console.Write("Forty "); break;
                    case 5: Console.Write("Fifty "); break;
                    case 6: Console.Write("Sixty "); break;
                    case 7: Console.Write("Seventy "); break;
                    case 8: Console.Write("Eighty "); break;
                    case 9: Console.Write("Ninety "); break;
                }
                switch (num % 10)
                {
                    case 1: Console.Write("One "); break;
                    case 2: Console.Write("Two "); break;
                    case 3: Console.Write("Three "); break;
                    case 4: Console.Write("Four "); break;
                    case 5: Console.Write("Five "); break;
                    case 6: Console.Write("Six "); break;
                    case 7: Console.Write("Seven "); break;
                    case 8: Console.Write("Eight "); break;
                    case 9: Console.Write("Nine "); break;
                }
            }
        }

        static void teens(int num)
        {
            switch (num)
            {
                case 10: Console.Write("Ten "); break;
                case 11: Console.Write("Eleven "); break;
                case 12: Console.Write("Twelve "); break;
                case 13: Console.Write("Thirteen "); break;
                case 14: Console.Write("Fourteen "); break;
                case 15: Console.Write("Fifteen "); break;
                case 16: Console.Write("Sixteen "); break;
                case 17: Console.Write("Seventeen "); break;
                case 18: Console.Write("Eighteen "); break;
                case 19: Console.Write("Nineteen "); break;
            }
        }
    }
}       
