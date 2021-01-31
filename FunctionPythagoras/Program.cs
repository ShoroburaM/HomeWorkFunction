using System;

namespace FunctionPythagoras
{
    class Program
    {
        static int Spase(int maxnumb) 
        {
            int spase;
            if (maxnumb >= 0 && maxnumb < 10)
            {
                spase = 0;
                return spase;
            }
            else if (maxnumb >= 10 && maxnumb < 100)
            {
                spase = 1;
                return spase;
            }
            else if (maxnumb >= 100 && maxnumb < 1000)
            {
                spase = 2;
                return spase;
            }
            else
            {
                spase = 3;
                return spase;
            }

        }

        static void Pythagoras(int hend, int vend)
        {
           
            int hstart = 1;

            int vstart = 1;

            int max = hend * vend;
            int length;
            if (max >= 0 && max <= 9)
            {
                length = 1;
            }
            else if (max > 9 && max <= 99)
            {
                length = 2;
            }
            else if (max > 99 && max <= 999)
            {
                length = 3;
            }
            else
            {
                length = 4;
            }
            

            //ПРОРИСОВКА ПЕРШОЇ ЛІНЇ

            int spase = Spase(vstart);
            for (int i = 0; i <= length - spase; i++)
            {
                Console.Write(" ");
            }

            Console.Write(" |");

            int x = vstart;


            while (x <= hend)
            {

                int spase1 = Spase(x); ;
                for (int i = 0; i <= length - spase1; i++)
                {
                    Console.Write(" ");

                }
                Console.Write(x);
                x++;

            }
            Console.WriteLine();

            //ПРОРИСОВКА ДРУГОЇ ЛІНЇ

                int spase2 = Spase(vstart); 
                for (int i = 0; i <= length - spase2; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("-+");

            for (int line = hstart;  line <= hend; line++)
            {
                int linelong1 = 0;
                while (linelong1 <= length)
                {
                    Console.Write("-");
                    linelong1++;
                }
                if (line >= 0 && line < 100)
                {
                    Console.Write("-");
                }
                else if (line >= 100 && line < 1000)
                {
                    Console.Write("--");
                }
                
                else
                {
                    Console.Write("----");
                }

            }
            
            Console.WriteLine();

            //ПРОРИСОВКА МАСИВА
            x = hstart;
            while (x <= hend)
            {
                while (vstart <= vend)
                {
                    int spase3 = Spase(vstart);
                    for (int i = 0; i <= length - spase3; i++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write(vstart + "|");

                    x = hstart;

                    while (x <= hend)
                    {

                        int sum = vstart * x;
                        int spase4 = Spase(sum);
                        for (int i = 0; i <= length - spase4; i++)
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
