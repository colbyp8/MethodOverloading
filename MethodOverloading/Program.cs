using System;

namespace MethodOverloading
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            //Add(5, 3);
            //Add(5.5m, 3.2m);
            //Add(2, 13, true);
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        public static string Add(int num1, int num2, bool x)
        {
            var sum = num1 + num2;
            if (x == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else
            {
                return $"{sum} dollars";
            }
        }
    }
}
