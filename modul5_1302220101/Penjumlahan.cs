﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302220101
{
    internal class Penjumlahan
    {
        public static void JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
        {
            dynamic n1 = angka1;
            dynamic n2 = angka2;
            dynamic n3 = angka3;

            Console.WriteLine(n1 + n2 + n3);
        }
    }
}
