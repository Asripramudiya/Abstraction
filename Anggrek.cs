using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Anggrek : Bunga, ICiri
    {
        public override void Warna()
        {
            Console.WriteLine("Anggrek bewarna Cerah");
        }
        public void ciri()
        {
            Console.WriteLine("Anggrek bentuknya menyerupai serangga");
            Console.WriteLine("Anggrek memiliki akar serbaguna");
        }
    }
}
