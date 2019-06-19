using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziIslemleri
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int n = 0;
            int carpım = 1;
            Console.Write("Dizinin eleman sayısını giriniz:");
            n = Convert.ToInt32(Console.ReadLine());           
            int[] Array = new int[n];
            int[] Array1 = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("A[" + i + "] elemanını giriniz:");
                Array[i] = Convert.ToInt32(Console.ReadLine());
                carpım = Array[i] * carpım;
              
            }
            for (int i = 0; i < n; i++)
            {
                Array1[i] = carpım / Array[i];
                Console.WriteLine("B[" + i + "]=" + Array1[i]);
                
            }
            Console.ReadLine();
        }
    }
}
