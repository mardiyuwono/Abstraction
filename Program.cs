using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Abstraction.AbstractClass;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Bioskop bioskop;  
            bioskop = new Bloodshot();
            bioskop.Film();

            Console.WriteLine();
            bioskop = new Vanguard();
            bioskop.Film();

            Console.WriteLine();
            bioskop = new Mulan();
            bioskop.Film();

            Console.ReadKey();
        }
    }
}
