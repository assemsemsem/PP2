using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1T1
{
    class Program
    {

        static void Main(string[] args)
        {
            int n;
            string s;
            s = Console.ReadLine();

            n = int.Parse(s);


            string line;
            line = Console.ReadLine();

            string[] arr = line.Split();
            int x, cnt = 0;


            for (int i = 0; i < n; i++)
            {
                x = int.Parse(arr[i]);


                for (int j = 2; j < x; j++)
                {
                    if (x % j == 0)
                    {
                        cnt++;
                    }

                }

                if (cnt < 1)
                {
                    Console.WriteLine(arr[i]);
                }


            }







        }
    }
}
