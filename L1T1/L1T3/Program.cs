using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1T3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            
            s = Console.ReadLine();

            int n = int.Parse(s);

            string ss;
            ss = Console.ReadLine();
            string[] arr1;

            arr1 = ss.Split();
            int x;
            
            for (int i = 0; i < n; i++)
            {
                x = int.Parse(arr1[i]);
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(arr1[i]);
                }
            }
        }
    }
}
