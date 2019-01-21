using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBazz
{
   public class FizzBuzzer
    {
        public string Get(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (number % 3==0)
            {
                return "Fizz";
            }
            else if(number % 5==0)
            {
                return "Buzz";

            }
            return number.ToString();
        }
        public string WidthBool(int number)
        {
            if (with3and5(number))
            {
                return "FizzBuzz";
            }
            else  if (with3(number)) 
           {
                return "Fizz";
            }
            else if (with5(number))
            {
                return "Buzz";
            }
           

            return number.ToString();
        }
        bool with3(int input)
            {
                return input % 3 == 0;
            }
        bool with5(int input)
            {
                return input % 5 == 0;
            }
        bool with3and5(int input)
            {
                return (with3(input) && with5(input));
            }
        
    }
}
