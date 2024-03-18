using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_06888
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int X = Int32.Parse(sr.ReadLine());
            int Y = Int32.Parse(sr.ReadLine());

            int i = 0;
            while (true)
            {
                if (i % 4 == 0 && i % 2 == 0 && i % 3 == 0 && i % 5 == 0)
                {
                    X += i;
                    if (X > Y)
                    {
                        sr.Close();
                        sw.Close();
                        break;
                    }
                    sw.WriteLine("All positions change in year " + X);
                    i = 0;
                }

                i++;
            }
        }
    }
}
