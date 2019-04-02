using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class ConvertLowercaseToUppercase
    {
        static void Main(string[] args)
        {
            char a;
            int b;

            Console.WriteLine("Enter a letter between a-z:");

            a = Convert.ToChar(Console.ReadLine());
            b = (int)a;

            if (b >= 97 && b <= 122) 
            {
                b = b - 32;

                a = (char)b;
                Console.WriteLine("In Upper Case Letter:" + a);
            }
            else
            {
                Console.WriteLine("You have entered an incorrect letter between a-z...");
            }
            Console.ReadKey();
        }
    }
}
