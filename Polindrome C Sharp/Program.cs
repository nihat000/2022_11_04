using System;

namespace Polindrome_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myNum = 53211235;
            int num = myNum;
            int reversedNum = 0;

            while (num >= 1)
            {
                int digit = num % 10;
                reversedNum = reversedNum * 10 + digit;
               num = (num - num % 10) / 10;
            }

            Console.WriteLine(reversedNum);
            if (reversedNum == myNum)
            {
                Console.WriteLine(myNum + " It is polindrome number");
            }
            else
            {
                Console.WriteLine(myNum + " It isn't polindrome number");
            }
        }
    }
}