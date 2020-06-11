using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Trapesium : IBangunDatar
    {
        public int x;

        public void luas()
        {
            Console.Write("Masuk kan Nilai Sisi    = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("luas persegi           = " + (x * 1/2 *x));
        }

        public void keliling()
        {
            Console.WriteLine("keliling persegi       = " + (4 * x));
        }
    }
}
