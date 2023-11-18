using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_24294
    {
        public void solve()
        {
            int w1 = Int32.Parse(Console.ReadLine());
            int h1 = Int32.Parse(Console.ReadLine());
            int w2 = Int32.Parse(Console.ReadLine());
            int h2 = Int32.Parse(Console.ReadLine());

            Console.Write((h1 + h2 + 2) * 2 + (Math.Max(w1, w2) * 2));
        }
    }
}
