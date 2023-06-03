using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentcgpa
{
    internal class StudenInput
    {
        public string Name { get; set; }
        public int Number { get; set; }

        public StudenInput(String name) { 
            
            Name = name;

        }
        public void Display()
        {
            Console.WriteLine("we working on it.... enter marks");
            Number=int.Parse(Console.ReadLine());
            if(Number != 80)
            {
                Console.WriteLine($"{Name} have passed the exaam");
            }
        }
    }
}
