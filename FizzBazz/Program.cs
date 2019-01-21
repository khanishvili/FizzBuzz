using System;

namespace FizzBazz
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            FizzBuzzer bz = new FizzBuzzer();
            input=   bz.Get(15);
            Console.WriteLine(input.ToString());
            input = bz.Get(6);
            Console.WriteLine(input.ToString());

        }

    }
}
