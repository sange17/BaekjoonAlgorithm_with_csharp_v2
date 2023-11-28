using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_30468
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string line = sr.ReadLine();

            int STR = Int32.Parse(line.Split(' ')[0]);
            int DEX = Int32.Parse(line.Split(' ')[1]);
            int INT = Int32.Parse(line.Split(' ')[2]);
            int LUK = Int32.Parse(line.Split(' ')[3]);
            int N = Int32.Parse(line.Split(' ')[4]);

            int sum = STR + DEX + INT + LUK;
            int count = 0;
            while (sum / 4 < N)
            {
                sum++;
                count++;
                
            }

            Console.Write(count);
        }
    }
}
