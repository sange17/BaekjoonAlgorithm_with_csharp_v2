namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_03076
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string line = sr.ReadLine()!;
            int R = Int32.Parse(line.Split(" ")[0]);
            int C = Int32.Parse(line.Split(" ")[1]);
            line = sr.ReadLine()!;
            int A = Int32.Parse(line.Split(" ")[0]);
            int B = Int32.Parse(line.Split(" ")[1]);
            bool flag = false;
            for (int i = 0; i < R * A; i++)
            {
                for (int j = 0; j < C * B; j++)
                {
                    // 홀수 행
                    if ((i / A) % 2 == 0)
                    {
                        // 홀수 열
                        if ((j / B) % 2 == 0)
                        {
                            sw.Write("X");
                        }
                        // 짝수 행
                        else
                        {
                            sw.Write(".");
                        }
                    }
                    // 짝수 행
                    else
                    {
                        // 홀수 행
                        if ((j / B) % 2 == 0)
                        {
                            sw.Write(".");
                        }
                        // 짝수 행
                        else
                        {
                            sw.Write("X");
                        }
                    }
                }

                sw.WriteLine();
            }

            sr.Close();
            sw.Close();
        }
    }
}
