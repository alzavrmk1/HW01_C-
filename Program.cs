using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            if (args.Length == 0)
            {
                Console.WriteLine("Вы не ввели числа!");
            }
            else
            {
                Double numA = Convert.ToDouble(args[0]);
                Double numB = Convert.ToDouble(args[1]);
                Console.WriteLine($"{args[0]} + {args[1]} = {numA + numB:0.0000}");
                Console.WriteLine($"{args[0]} - {args[1]} = {numA - numB:0.0000}");
                Console.WriteLine($"{args[0]} * {args[1]} = {numA * numB:0.0000}");

                if (numB == 0) 
                {
                    Console.WriteLine("Деление на нуль!");
                }
                else
                {
                    Console.WriteLine($"{args[0]} / {args[1]} = {numA / numB:0.0000}");
                }  
            }

            
        }
    }
}