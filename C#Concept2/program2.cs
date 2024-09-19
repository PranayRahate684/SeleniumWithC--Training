using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace C_Concept2
{
    public class Area
    {
        static void Main(String[] args)
        {
           Area.AreaofTriangle Ar = new AreaofTriangle();
            Console.WriteLine("Area of Triangle is : "+Ar.AreaofTriangle(23.2, 423.3));
            
         

            String[] sd = new string[2];
            sd[0] = "dsa";
            sd[1] = "asdf";
            Console.WriteLine(sd);
            
            Ar.quit();

        }

    }
}
