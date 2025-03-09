namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_14535
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int T = 1;
            while (true)
            {
                int N = Int32.Parse(sr.ReadLine()!);
                if (N == 0)
                {
                    sr.Close();
                    sw.Close();
                    break;
                }

                string[] monthArray = { "Jan:", "Feb:", "Mar:", "Apr:", "May:", "Jun:", "Jul:", "Aug:", "Sep:", "Oct:", "Nov:", "Dec:" };

                sw.WriteLine("Case #" + T + ":");

                for (int i = 0; i < N; i++)
                {
                    string line = sr.ReadLine()!;
                    int month = Int32.Parse(line.Split(" ")[1]);

                    if (month == 1) monthArray[0] += "*";
                    else if (month == 2) monthArray[1] += "*";
                    else if (month == 3) monthArray[2] += "*";
                    else if (month == 4) monthArray[3] += "*";
                    else if (month == 5) monthArray[4] += "*";
                    else if (month == 6) monthArray[5] += "*";
                    else if (month == 7) monthArray[6] += "*";
                    else if (month == 8) monthArray[7] += "*";
                    else if (month == 9) monthArray[8] += "*";
                    else if (month == 10) monthArray[9] += "*";
                    else if (month == 11) monthArray[10] += "*";
                    else if (month == 12) monthArray[11] += "*";
                }

                for (int i = 0; i < 12; i++)
                {
                    sw.WriteLine(monthArray[i]);
                }

                T++;
            }
        }
    }
}
