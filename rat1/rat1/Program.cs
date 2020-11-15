using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rat1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am Ratul");
            int x = 5;
            int y = 6;
            int sum = x + y;
            Console.WriteLine(sum);

            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
            

            int l, b;
            Console.Write("Enter the length of Rectangle: ");
            l = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the breadth of Rectangle: ");
            b = Convert.ToInt32(Console.ReadLine());
            int area = l * b;
            int peri = 2 * (l + b);
            Console.WriteLine("Area of Rectangle is = {0} and Perimeter is ={1}", area, peri);
            Console.ReadKey();

            Console.ReadLine();

        }
    }
}
