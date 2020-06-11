using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Mawar : Bunga, ICiri
    {
        public override void Warna()
        {
            Console.WriteLine("Mawar bewarna Merah");
        }
        public void ciri()
        {
            Console.WriteLine("Mawar mengeluarkan aroma yang harum");
            Console.WriteLine("Mawar terdiri dari lima helai kelopak mahkota");
        }
    }
}
