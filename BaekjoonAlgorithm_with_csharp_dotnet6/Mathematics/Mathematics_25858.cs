using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_25858
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string line = sr.ReadLine();
            int N = Int32.Parse(line.Split(' ')[0]);
            int money = Int32.Parse(line.Split(' ')[1]);
            int[] array = new int[N];

            int sum = 0;
            int num = 0;
            for(int i = 0; i < N; i++)
            {
                num = Int32.Parse(sr.ReadLine());
                array[i] = num;
                sum += num;
            }

            int div = money / sum;
            for(int i = 0; i < N; i++)
            {
                sw.WriteLine(array[i] * div);
            }

            sr.Close();
            sw.Close();
        }
    }
}
