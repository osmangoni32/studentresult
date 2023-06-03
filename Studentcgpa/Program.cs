using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentcgpa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("okk");
           
            StudenInput si1 = new StudenInput("jahid");
            si1.Display();
            Console.ReadKey();
        }
    }
}
