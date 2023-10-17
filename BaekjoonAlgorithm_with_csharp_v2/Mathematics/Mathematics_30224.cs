using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonAlgorithm_with_csharp_v2.Mathematics
{
    class Mathematics_30224
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine());

            if (n % 7 != 0 && !n.ToString().Contains('7')) Console.WriteLine(0);
            else if (n % 7 == 0 && !n.ToString().Contains('7')) Console.WriteLine(1);
            else if (n % 7 != 0 && n.ToString().Contains('7')) Console.WriteLine(2);
            else if (n % 7 == 0 && n.ToString().Contains('7')) Console.WriteLine(3);
        }
    }
}
