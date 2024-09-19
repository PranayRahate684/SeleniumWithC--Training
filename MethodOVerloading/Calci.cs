using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOVerloading
{
    internal class Calci
    {
        public void add(int a, int b)
        {
            Console.WriteLine(a+b);
        }

        public void add(int a, int b,int c)
        {
            Console.WriteLine(a + b+c);
        }

    }
}
