using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonAlgorithm_with_csharp_v2.Implementation
{
    class Implementation_28490
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine());

            int max = 0;

            string line = string.Empty;
            int a = 0;
            int b = 0;
            for(int i = 0; i < N; i++)
            {
                line = Console.ReadLine();

                a = Int32.Parse(line.Split(' ')[0]);
                b = Int32.Parse(line.Split(' ')[1]);

                if(a * b > max)
                {
                    max = a * b;
                }
            }

            Console.WriteLine(max);
        }
    }
}
