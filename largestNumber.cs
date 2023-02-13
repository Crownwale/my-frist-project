using System;
 
namespace Basics1
{
    class Number
    {
        public void large()
        {
            Console.Write("Type number 1:");    
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Type number 2:");    
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Type number 3:");    
            double c = Convert.ToDouble(Console.ReadLine());

            Console.Write("Type number 4:");    
            double d = Convert.ToDouble(Console.ReadLine());

            Console.Write("Type number 5:");    
            double e = Convert.ToDouble(Console.ReadLine());

            double max;
            if (a > b && a > c && a > d && a > e)
            {
            max = a;
            Console.WriteLine("The biggest number from {0} , {1} and {2} is {3}.", a, b, c, max);
            }
            else if (b > a && b > c && b > d && b > e)
            {
            max = b;
            Console.WriteLine("The biggest number from {0} , {1} and {2} is {3}.", a, b, c, max);
            }
            else if (c > a && c > b && c > d && c > e)
            {
            max = c;
            Console.WriteLine("The biggest number from {0} , {1} and {2} is {3}.", a, b, c, max);
            }
            else if (d > a && d > b && d > c && d > e)
            {
            max = d;
            Console.WriteLine("The biggest number from {0} , {1} and {2} is {3}.", a, b, c, max);
            }
            else
            {
            max = e;
            Console.WriteLine("The biggest number from {0} , {1} and {2} is {3}.", a, b, c, max);
            }
        }
    }
};