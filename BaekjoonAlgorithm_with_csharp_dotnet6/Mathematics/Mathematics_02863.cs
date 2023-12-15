using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_02863
    {
        public void solve()
        {
            string line = Console.ReadLine();
            int a = Int32.Parse(line.Split(' ')[0]);
            int b = Int32.Parse(line.Split(' ')[1]);
            line = Console.ReadLine();
            int c = Int32.Parse(line.Split(' ')[0]);
            int d = Int32.Parse(line.Split(' ')[1]);

            double[] array =
            {
                ((double)a / c) + ((double)b / d),
                ((double)c / d) + ((double)a / b),
                ((double)d / b) + ((double)c / a),
                ((double)b / a) + ((double)d / c)
            };

            double max = 0;
            int idx = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if(max < array[i]) 
                { 
                    max = array[i];
                    idx = i;
                }
            }

            Console.Write(idx);
        }
    }
}
