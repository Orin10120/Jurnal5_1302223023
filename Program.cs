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

        public simpleDatabase()
        {
            this.storedData = new List<T>();
            this.inputdates = new List<DateTime>();
        }

        public void AddNewData(T data)
        {
            this.storedData.Add(data);
            this.inputdates.Add(DateTime.Now);
        }

        
        public void printAllData()
        {
            for (int i = 0; i < this.storedData.Count; i++)
            {
                Console.WriteLine("data: " + storedData[i] + " Waktu: " + inputdates);
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            simpleDatabase<double> dataNew = new simpleDatabase<double>();
            dataNew.AddNewData(13);
            dataNew.AddNewData(22);
            dataNew.AddNewData(30);
            dataNew.printAllData();
        }
    }
}
