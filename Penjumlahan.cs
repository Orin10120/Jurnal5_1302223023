using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jurnal5
{
    class Penjumlahan<T>
    {
        public T JumlahTigaAngka(T angka1, T angka2, T angka3)
        {
            dynamic a, b, c;
            a = (dynamic)angka1;
            b = (dynamic)angka2;
            c = (dynamic)angka3;
            return a + b + c;
        }
    }
}
