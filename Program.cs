using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jurnal5
{
    public class simpleDatabase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputdates;

        simpleDatabase(List<T> storedData, List<DateTime> inputdates)
        {
            this.storedData = storedData;
            this.inputdates = inputdates;
        }

        public void AddNewData(T data, T inputDates)
        {
            this.storedData.Add(data);

        }

        public T JumlahTigaAngka(T angka1, T angka2, T angka3)
        {
            return angka1
        }
        
        public void printAllData()
        {
            Console.WriteLine();
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
