using System;

namespace FunctionTriangle
{
    class Program                                               //Трикутник
    {
        static void Triangle (int h)
        {
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter height your triangle");
            int height = int.Parse(Console.ReadLine());
            Triangle(height);
        }
    }
}
