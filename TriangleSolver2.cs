using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070A2
{
    public class TriangleSolver
    {
       
        public static string analyze(decimal dem1, decimal dem2, decimal dem3)
        {
                if (dem1 == dem2 && dem2 == dem3 && dem1 > 0 &&  dem1 >0 && dem2 > 0 && dem3 > 0)
                {
                    Console.WriteLine("Triangle is an equilateral");
                }
                else if (dem1 == dem2 || dem1 == dem3 || dem2 == dem3 && dem1 > 0 && dem2 > 0 && dem3 > 0)
                {
                    Console.WriteLine("Traingle is an isosceles");
                }
                else if (dem1 != dem2 && dem2 != dem3 && dem3 != dem1 && dem1 > 0 && dem2 > 0 && dem3 > 0)
                {
                    Console.WriteLine("Triangle is Scalene");
                }
                else
                {
                    Console.WriteLine("Error");
                }

            return ("Good Luck");
           
        }
  
    }
}
