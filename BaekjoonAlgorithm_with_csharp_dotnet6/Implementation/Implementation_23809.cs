﻿namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_23809
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int N = Int32.Parse(Console.ReadLine());

            for(int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                    sw.Write("@");
                for (int j = 0; j < N * 3; j++)
                    sw.Write(" ");
                for(int j = 0; j < N; j++)
                    sw.Write("@");
                sw.WriteLine();
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                    sw.Write("@");
                for (int j = 0; j < N * 2; j++)
                    sw.Write(" ");
                for (int j = 0; j < N; j++)
                    sw.Write("@");
                sw.WriteLine();
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N * 3; j++)
                    sw.Write("@");
                sw.WriteLine();
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                    sw.Write("@");
                for (int j = 0; j < N * 2; j++)
                    sw.Write(" ");
                for (int j = 0; j < N; j++)
                    sw.Write("@");
                sw.WriteLine();
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                    sw.Write("@");
                for (int j = 0; j < N * 3; j++)
                    sw.Write(" ");
                for (int j = 0; j < N; j++)
                    sw.Write("@");
                sw.WriteLine();
            }

            sr.Close();
            sw.Close();
        }
    }
}
