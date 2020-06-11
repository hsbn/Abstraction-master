using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractionClass
{
    public class segitiga : BangunDatar
    {
        public int L = 0;
        public float i,t;

        public override void Luas()
        {

            Console.Write("Masuk kan Nilai Alas        = ");
            i = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masuk kan Nilai Tinggi     = ");
            t = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan Nilai Sisi            = ");
            L = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("luas segitiga                = " + ((i * t) / 2));
            
        }

        public override void Keliling()
        {
            Console.WriteLine("keliling segitiga         = " + (L + L + L));
        }
    }
}
