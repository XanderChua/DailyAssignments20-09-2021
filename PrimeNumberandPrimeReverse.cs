using System;

namespace PrimeNumberandPrimeReverse
{
    class PrimeNumberandPrimeReverse
    {
        public static int ReverseNo(int num) //reverse the number
        {
            int revNo = 0;
            while (num > 0)
            {
                revNo = revNo * 10 + num % 10;
                num = num / 10;
            }
            return revNo;
        }
        public static bool IsPrime(int input) //check prime
        {
            bool isPrime = true;
            for (int i = 2; i < input / 2; i++)
            {
                if (input % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }

        static void Main(string[] args)
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Write a number between 1 to 100:");
                int input = Int32.Parse(Console.ReadLine());
                int revNo = ReverseNo(input);

                if ((input > 1 || input < 100) && IsPrime(input) && IsPrime(revNo))
                {
                    Console.WriteLine("Input number reversed: " + revNo);                  
                    Console.WriteLine(input + " is a prime number");
                    Console.WriteLine(revNo + " is a reversed prime number\n");
                }
                else if ((input > 1 || input < 100) && IsPrime(input))
                {
                    Console.WriteLine("Input number reversed: " + revNo);
                    Console.WriteLine(input + " is a prime number");
                    Console.WriteLine(revNo + " is not a reversed prime number\n");
                }
                else if ((input > 1 || input < 100) && IsPrime(revNo))
                {
                    Console.WriteLine("Input number reversed: " + revNo);
                    Console.WriteLine(input + " is not a prime number");
                    Console.WriteLine(revNo + " is a reversed prime number\n");
                }
                else if((input < 1 || input > 100))
                {
                    Console.WriteLine("Please enter a number between 1 to 100");
                }
                else
                {
                    Console.WriteLine("Input number reversed: " + revNo);
                    Console.WriteLine(input + " is not a prime number");
                    Console.WriteLine(revNo + " is not a reversed prime number\n");
                }
            }
        }
    }
}
