using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302220101
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Penjumlahan.JumlahTigaAngka<float>(13, 02, 22);
            SimpleDataBase<float> SDB = new SimpleDataBase<float>();
            SDB.AddNewData(13);
            SDB.AddNewData(02);
            SDB.AddNewData(22);
            SDB.PrintAllData();
        }
    }
}
