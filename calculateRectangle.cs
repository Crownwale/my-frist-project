using System;

namespace Basics1
{
 class Rectangle
    {
       public void arae()
        {
         Console.Write("Enter length: ");
         double L = Convert.ToDouble(Console.ReadLine());
         Console.Write("Enter Breath: ");
         double B = Convert.ToDouble(Console.ReadLine());
         double Area = L * B;
         Console.WriteLine("Area of Rectangle: " + Area);
         Console.ReadKey();
        }
    }
};