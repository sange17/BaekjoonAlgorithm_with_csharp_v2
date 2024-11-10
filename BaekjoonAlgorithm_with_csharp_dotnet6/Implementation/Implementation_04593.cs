namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_04593
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            while (true)
            {
                string P1 = sr.ReadLine()!;
                string P2 = sr.ReadLine()!;
                int p1Win = 0;
                int p2Win = 0;

                if (P1 == "E" && P2 == "E") break;

                for (int i = 0; i < P1.Length; i++)
                {
                    if (P1[i] == 'R' && P2[i] == 'S') p1Win++;
                    else if (P1[i] == 'R' && P2[i] == 'P') p2Win++;
                    else if (P1[i] == 'S' && P2[i] == 'P') p1Win++;
                    else if (P1[i] == 'S' && P2[i] == 'R') p2Win++;
                    else if (P1[i] == 'P' && P2[i] == 'R') p1Win++;
                    else if (P1[i] == 'P' && P2[i] == 'S') p2Win++;
                }

                sw.WriteLine("P1: " + p1Win + "\nP2: " + p2Win);
            }

            sr.Close();
            sw.Close();
        }
    }
}
