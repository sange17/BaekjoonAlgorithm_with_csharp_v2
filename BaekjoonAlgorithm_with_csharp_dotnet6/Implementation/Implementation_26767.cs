using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_26767
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int N = Int32.Parse(sr.ReadLine());

            for(int i = 1; i <= N; i++)
            {
                if(i % 7 == 0 && i % 11 != 0)
                {
                    sw.WriteLine("Hurra!");
                }
                else if(i % 7 != 0 && i % 11 == 0)
                {
                    sw.WriteLine("Super!");
                }
                else if(i % 7 == 0 && i % 11 == 0)
                {
                    sw.WriteLine("Wiwat!");
                }
                else
                {
                    sw.WriteLine(i);
                }
            }

            sr.Close();
            sw.Close();
        }
    }
}
