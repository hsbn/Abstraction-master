using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractionClass
{

    public class Trapesium : BangunDatar
    {
        public int h;

        public override void Luas()
        {
            Console.Write("Masuk kan Nilai Sisi   = ");
            h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("luas persegi          = " + (h * 1/2 * h));
        }

        public override void Keliling()
        {
            Console.WriteLine("keliling persegi     = " + (4 * h));
            
        }
    }
}
