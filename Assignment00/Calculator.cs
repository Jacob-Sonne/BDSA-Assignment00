using System;

namespace Assignment00
{
    public static class Calculator
    {
        public static int SumDigits(string number)
        {
            char[] chars = number.ToCharArray();

            var sum = 0;

            foreach(char c in chars){
                sum += c - '0';
            }

            return sum;
        }
    }

}