using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_11522
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int N = Int32.Parse(sr.ReadLine()!);

            for (int i = 0; i < N; i++)
            {
                int[] inputs = sr.ReadLine()!.Split().Select(int.Parse).ToArray();
                int sum = 0;

                for (int j = 1; j <= inputs[1]; j++)
                {
                    sum += j;
                }

                sw.WriteLine(inputs[0] + " " + sum + " " + (inputs[1] * inputs[1]) + " " + (inputs[1] * inputs[1] + inputs[1]));
            }

            sr.Close();
            sw.Close();
        }
    }
}
