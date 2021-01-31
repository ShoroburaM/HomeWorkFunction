using System;

namespace FunctionDiamond
{
    class Program                                                   //Ромб
    {
        static void Diamond(int rows)
        {
            int hight;
            int spase;
            
            for (hight = 0; hight <= rows; hight++)
            {
                for (spase = 1; spase <= rows - hight; spase++)
                    Console.Write(" ");
                for (spase = 1; spase <= 2 * hight - 1; spase++)
                    Console.Write("*");
                Console.Write("\n");
            }

            for (hight = rows - 1; hight >= 1; hight--)
            {
                for (spase = 1; spase <= rows - hight; spase++)
                    Console.Write(" ");
                for (spase = 1; spase <= 2 * hight - 1; spase++)
                    Console.Write("*");
                Console.Write("\n");
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input number of rows");
            int r = int.Parse(Console.ReadLine());
            Diamond(r);
        }
    }
}
