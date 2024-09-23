using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_C__Concept
{
    internal class GetTOdayDate
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            Console.WriteLine("Today's date is: " + today.ToString("yyyy-MM-dd"));
        }
    }
}
