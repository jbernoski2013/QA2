using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070A2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal option;
            decimal dem1;
            decimal dem2;
            decimal dem3;

            TriangleSolver trianglesolver = new TriangleSolver();
            Restart:
            Console.WriteLine("1.Enter Triangle Demensions");
            Console.WriteLine("2.Exit");
            try
            {
                option = decimal.Parse(Console.ReadLine());
                
                if(option == 1)
                {
                    Retry:
                    Console.WriteLine("1st Demension: ");
                    try
                    {
                        dem1 = decimal.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please Enter a number");
                        goto Retry;
                    }
                    Retry2:
                    Console.WriteLine("2nd Demension: ");
                    try
                    {
                        dem2 = decimal.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please Enter a number");
                        goto Retry2;
                    }
                    Retry3:
                    Console.WriteLine("3rd Demension: ");
                    try
                    {
                        dem3 = decimal.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please Enter a number");
                        goto Retry3;
                    }

                    trianglesolver.analyze(dem1, dem2, dem3);
                    Console.ReadLine();

                    goto Restart;
                   
                }
                else if(option == 2)
                {
                    Environment.Exit(0);
                }
            }
            catch
            {
                Console.WriteLine("Please enter either 1 or 2");
            }
            
        }
    }
}
