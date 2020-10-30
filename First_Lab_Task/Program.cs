using System;

namespace First_Lab_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("RIMON");
            int a = 20;
            float b = 23.32f;
            float sum = a + b;
            Console.WriteLine("SUM=" + sum);
            float D=a/b;
            Console.WriteLine("Divide Ans=" + D);
            int c = -5;
            int d = 8;
            int e = 6;
            Console.WriteLine("First value of A=" + c + d * e);
            int g = 55;
            int h = 9;
            int i = 9;
            float j=(g+h)%9;
            Console.WriteLine("Second Value of B=" + j);
            int k = -3;
            int l = 5;
            Console.WriteLine("Third Num of C=" + (a + (k * l) / d));
            int m = 15;
            int n = 3;
            int o = 2;
            int p = 3;
            float q = l + m / n * o - d % n;
            Console.WriteLine("Ans of D=" + q);
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
            float width = 5.5f;
            float height = 8.5f;
            float Area, Perimeter;
            Area = width * height;
            Console.WriteLine("Area is " + Area);
            Perimeter = 2 *( width + height);
            Console.WriteLine("Perimeter is " + Perimeter);
            int first_integer = 25;
            int second_integer = 39;
            if(first_integer!=second_integer)
            {
                Console.WriteLine("25 != 39 ");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
            if (first_integer < second_integer)
            {
                Console.WriteLine("25< 39 ");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
            if (first_integer <= second_integer)
            {
                Console.WriteLine("25 <= 39 ");
            }
            else
            {
                Console.WriteLine("ERROR");
            }






        }
    }
}
