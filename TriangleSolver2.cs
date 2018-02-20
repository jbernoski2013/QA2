using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070A2
{
    class TriangleSolver
    {
       
        public  void analyze(decimal a, decimal b, decimal c)
        {
            if(a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Forms a triangle");
                if (a == b && b == c)
                {
                    Console.WriteLine("Triangle is an equilateral");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("Traingle is an isosceles");
                }
                else if (a != b && b != c && c != a)
                {
                    Console.WriteLine("Triangle is Scalene");
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            else
            {
                Console.WriteLine("Does not form a triangle");
            }
           
        }

        
    }
}
