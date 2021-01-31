using System;

namespace HomeWorkFunction                                          ///Калькулятор
{
    
    class Program
    {
        static int Sum(int a, int b) 
        {
            int result = a + b;
            return result;        
        }
        static int Subtract(int a, int b)
        {
            int result = a - b;
            return result;
        }
        static int Division(int a, int b)
        {
            int result = a / b;
            return result;
        }
        static int Multiply(int a, int b)
        {
            int result = a * b;
            return result;
        }
        static int Calculator(int a, int b, string _operator )
        {
            int result = 0;
            if (_operator == "+")
            {
                 result = Sum(a, b);
            }
            else if (_operator == "-")
            {
                 result =  Subtract(a, b);
            }
            else if (_operator == "/")
            {
                 result =  Division(a, b);
            }
            else if (_operator == "*")
            {
                 result =  Multiply(a, b);
            }
            return result; 
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Entering first number");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Entering second number");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Entering operator");
                string _operator = Console.ReadLine();
                Console.WriteLine("Result is:");
                int result = Calculator(a, b, _operator);
                Console.WriteLine(result);
            }
           
            


        }
    }
}
