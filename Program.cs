using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Anggrek bunga = new Anggrek();
            Mawar bunga2 = new Mawar();

            Console.WriteLine("Bunga Anggrek");

            bunga.Warna();
            bunga.ciri();
            Console.WriteLine();

            Console.WriteLine("Bunga Mawar");
            
            bunga2.Warna();
            bunga2.ciri();
            Console.ReadKey();
        }
    }
}
