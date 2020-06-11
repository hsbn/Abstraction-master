using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Abstraction.Interface;         

namespace Abstraction
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("BANGUN Datar Bro");
            Console.WriteLine();

            
            IBangunDatar bangundatar;   


            Console.WriteLine("1. Trapesium");
            bangundatar = new Trapesium();
            bangundatar.Luas();
            bangundatar.Keliling();

            Console.WriteLine();
            Console.WriteLine("2. Persegi Panjang");
            bangundatar = new PersegiPanjang();
            bangundatar.Luas();
            bangundatar.Keliling();

            Console.WriteLine();
            Console.WriteLine("3. Segitiga");
            bangundatar = new Segitiga();
            bangundatar.Luas();
            bangundatar.Keliling();

            Console.ReadKey(true);

        }

    }
}