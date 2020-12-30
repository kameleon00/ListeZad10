using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeZad10
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, int> gradovi = new SortedList<string, int>()
            {
                {"Kraljevo", 400000 },        //SORTIRANJE SE VRSI NA OSNOVU KLJUCA 
                {"Nis", 1400000 },            //U RASTUCEM REDOSLEDU
                {"Beograd", 20000000 }     
            };
            foreach (var grad in gradovi)
                Console.WriteLine(grad);

            Console.ReadLine();
        }
    }
}
