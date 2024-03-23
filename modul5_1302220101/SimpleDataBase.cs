using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302220101
{
    internal class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates = new List<DateTime>();

        public SimpleDataBase() {
            storedData = new List<T>();
        }

        public void AddNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.Now);
        }

        public void PrintAllData()
        {
            int len = storedData.Count;

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Data " +(i+1)+" berisi: "+storedData[i]+", yang disimpan pada waktu UTC: " + inputDates[i]);

            }

        }
    }
}
