using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3Average3no
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int a, b, c,Avg;
            Console.WriteLine("\nEnter 1st Number : ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("\nEnter 2nd Number : ");
            b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("\nEnter 3rd Number : ");
            c = Convert.ToInt16(Console.ReadLine());
            Avg = ((a + b + c) / 3);
            Console.WriteLine("\nAverage of given 3 numbers :{0}, Avg");
            Console.ReadKey();
            */
            int num1, num2, num3, avg;

            Console.Write("Enter 1st number :");
            num1 = Convert.ToInt32(Console.ReadLine()); //Read 1st Number
            Console.Write("Enter 2nd number :");
            num2 = Convert.ToInt32(Console.ReadLine()); //Read 2nd Number
            Console.Write("Enter 3rd number :");
            num3 = Convert.ToInt32(Console.ReadLine()); //Read 3rd Number

            avg = (number1 + number2 + number3) / 3;

            Console.Write("Avarage of 3 numbers is : {0}", avg);

            Console.ReadKey();
        }
    }
}
