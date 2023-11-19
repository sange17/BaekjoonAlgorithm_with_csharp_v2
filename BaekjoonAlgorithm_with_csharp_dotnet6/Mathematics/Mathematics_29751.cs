using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_29751
    {
        public void solve()
        {
            string line = Console.ReadLine();
            double W = double.Parse(line.Split(' ')[0]);
            double H = double.Parse(line.Split(' ')[1]);

            Console.Write(string.Format("{0:0.0}", W * H / 2.0));
        }
    }
}
