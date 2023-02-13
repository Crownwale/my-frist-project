using System;

namespace Basics1
{
 class square
    {
       public void areas()
        {
         Console.Write("Enter length: ");
         double L = Convert.ToDouble(Console.ReadLine());
         double Area = L * L;
         Console.WriteLine("Area of square: " + Area);
         Console.ReadKey();
        }
    }
};