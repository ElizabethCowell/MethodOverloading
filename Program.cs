using System;

namespace MethodOverloading
{
    class Program
    {
        public static int Add(int x, int y)
        {
            int sum = x + y;
            return sum;
        }

        public static double Add(double x, double y)
        {
            double decicmal = x + y;
            return decicmal;
        }

        public static string Add(int x, int y, bool isTrue)
        {
            var sum = x + y;
            if (isTrue == true)
            {
                
                if (sum == 1)
                {
                    return sum + " dollar";
                }
                else
                {
                    return sum + " dollars";
                }
            }
            else
                return $"{sum}";
        }
        static void Main(string[] args)
        {
            Console.WriteLine();
        }
    }
}
