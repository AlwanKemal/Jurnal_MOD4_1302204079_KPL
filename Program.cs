using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jurnal_MOD4_1302204079_KPL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Penjumlahan.JumlahTigaAngka<long>(13, 22, 40));
        }
    }
    class Penjumlahan
    {
        public static T JumlahTigaAngka<T>(T input1, T input2, T input3)
        {
            dynamic a = input1;
            dynamic b = input2;
            dynamic c = input3;

            return a + b + c;
        }
    }

}

