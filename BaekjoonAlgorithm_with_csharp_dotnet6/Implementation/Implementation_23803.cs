using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_23803
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int N = Int32.Parse(sr.ReadLine());

            for(int i = 0; i < N * 5; i++)
            {
                if(i < N * (5 - 1))
                {
                    for(int j = 1; j <= N; j++)
                    {
                        sw.Write("@");
                    }
                    sw.WriteLine();
                }
                else
                {
                    for(int j = 1; j <= N * 5; j++)
                    {
                        sw.Write("@");
                    }
                    sw.WriteLine();
                }
            }

            sr.Close();
            sw.Close();
        }
    }
}
