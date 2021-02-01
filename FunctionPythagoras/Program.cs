﻿using System;

namespace FunctionPythagoras
{
    class Program
    {
        static void Pythagoras(int hend, int vend)
        {
           
            int hstart = 1;

            int vstart = 1;

            int max = hend * vend;
            int length = 0;
           int maxcount = max;
            while (maxcount >=  1)
            {
                length++;
                maxcount = maxcount / 10;
            }
            

            //ПРОРИСОВКА ПЕРШОЇ ЛІНЇ

            
            for (int i = 0; i <= length-1; i++)
            {
                Console.Write(" ");
            }

            Console.Write(" |");

            int x = vstart;


            while (x <= hend)
            {
                int longline = x;
                int countlongline = 0;
                while (longline >= 1)
                {
                    countlongline++;
                    longline = longline / 10;
                }

                for (int i = 0; i <= length - countlongline; i++)
                {
                    Console.Write(" ");

                }
                Console.Write(x);
                x++;

            }
            Console.WriteLine();

            //ПРОРИСОВКА ДРУГОЇ ЛІНЇ

                
                for (int i = 0; i < length; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("-+");

            for (int line = hstart;  line <= hend; line++)
            {
                Console.Write("-");
                int linelong1 = 0;
               
                    while (linelong1 < length)
                    {
                        Console.Write("-");
                        linelong1++;
                    }
            }
            
            Console.WriteLine();

            //ПРОРИСОВКА МАСИВА
            x = hstart;
            while (x <= hend)
            {
                while (vstart <= vend)
                {
                    int longline = vstart;
                    int countlongline = 0;
                    while (longline >= 1)
                    {
                        countlongline++;
                        longline = longline / 10;
                    }
                    for (int i = 0; i <= length - countlongline; i++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(vstart + "|");

                    x = hstart;

                    while (x <= hend)
                    {
                        int sum = vstart * x;
                        int longline1 = sum;
                        int countlongline1 = 0;
                        while (longline1 >= 1)
                        {
                            countlongline1++;
                            longline1 = longline1 / 10;
                        }
                        for (int i = 0; i <= length - countlongline1; i++)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(sum);
                        x++;
                    }
                    Console.WriteLine();
                    vstart++;
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of digits Horizontal ");
            int hend = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of digits Vertical ");
            int vend = int.Parse(Console.ReadLine());
            
            Pythagoras(hend, vend);
        }
    }
}
