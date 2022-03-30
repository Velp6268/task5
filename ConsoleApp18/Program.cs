using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var intList = new List<int>() { 1, 2, 3, 7, 19, 31, 5, 11, 20, 15, 8, 4};
            int temp;
            int n = 0;

            for (int i = 0; i < 13 -1; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    if (intList[i] > intList[j])
                    {
                        temp = intList[i];
                        intList[i] = intList[j];
                        intList[j] = temp;
                        n++;
                    }
                }
              
            }

            foreach (int num in intList)
                Console.WriteLine(num + " ");
            Console.WriteLine("\nЧисло перестановок при сортировки: " + n);
            Console.ReadKey();
        }
    }
}
        



   