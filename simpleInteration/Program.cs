using System;

namespace simpleInteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Put x and e");
            double x0 = 1.5;
            double e = 0.00001;

            double x1 = Function( x0);
            while(Math.Abs(x1 - x0) > e)
            {
                Console.WriteLine(x1);
                x0 = x1;
                x1 = Function(x0);
            }
            double x = x1;
            Console.WriteLine(Math.Round(x, 5, MidpointRounding.AwayFromZero));
        }

        public static double Function(double x)
        {

            return x - 0.4*(x* Math.Sin(x) - 1);
        }
    }
}
