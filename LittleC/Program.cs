using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleC
{
    class Program
    {
        static void Main(string[] args)
        {
            start:  decimal a, b, c;
            Console.WriteLine("Enter first number");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x % 3 != 0)
            {
                decimal z = x / 3;
                z = Math.Round(z, 0);
                decimal sum = z + z + z;
                decimal summ = x - sum;
                a = z;
                b = z;
                c = b +  summ;
                if (c % 3 != 0)
                {
                    Console.WriteLine(a + " " + b + " " + c);
                   
                }
                else
                {
                    b--;
                    c++;
                    Console.WriteLine(a + " " + b + " " + c);
                }
            }
             
            else
            {
                int y = x / 3;
                for (int i = 0; i != 3; i++)
                {
                    Console.Write(y);
                    Console.Write(" ");
                }

                
            }

            Console.WriteLine("\nRestart? y/n");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "y":
                    goto start;
                    break;
                case "n":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("enter y or n");
                    break;
            }
                
            Console.ReadKey();
        }
    }
}
