using System;

namespace Basics1
{
 class circle
    {
       public void area()
        {
         Console.Write("Enter Radius: ");
         double Radious = Convert.ToDouble(Console.ReadLine());
         double Area = 2 * Math.PI * Radious * Radious;
         Console.WriteLine("Area of circle: " + Area);
         Console.ReadKey();
        }
    }
};