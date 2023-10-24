using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonAlgorithm_with_csharp_v2.Mathematics
{
    class Mathematics_27262
    {
        public void solve()
        {
            string line = Console.ReadLine();

            int n = Int32.Parse(line.Split(' ')[0]);
            int k = Int32.Parse(line.Split(' ')[1]);
            int a = Int32.Parse(line.Split(' ')[2]);
            int b = Int32.Parse(line.Split(' ')[3]);

            Console.WriteLine(((k - 1) * b) + ((n - 1) * b) + " " + ((n - 1) * a));
        }
    }
}
