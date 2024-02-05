using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_05356
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int N = Int32.Parse(sr.ReadLine());

            string line = string.Empty;
            int num = 0;
            int alphabet = 0;
            for (int i = 0; i < N; i++)
            {
                line = sr.ReadLine();

                num = Int32.Parse(line.Split(" ")[0]);
                alphabet = line.Split(' ')[1][0];

                for(int j = 1; j <= num; j++)
                {

                    if(alphabet > 90)
                    {
                        alphabet = 64 + alphabet - 90;
                    }

                    for(int k = 1; k <= j; k++)
                    {

                        sw.Write((char)alphabet);
                    }
                    alphabet++;

                    sw.WriteLine();
                }
                sw.WriteLine();
            }

            sr.Close();
            sw.Close();
        }
    }
}
