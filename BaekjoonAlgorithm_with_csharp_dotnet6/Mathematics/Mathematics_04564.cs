namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_04564
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            while (true)
            {
                int N = Int32.Parse(sr.ReadLine()!);
                if(N == 0)
                {
                    sr.Close();
                    sw.Close();
                    break;
                }

                string strN = N.ToString();
                while (true)
                {
                    int cal = 1;
                    sw.Write(strN + " ");
                    if (strN.Length == 1)
                    {
                        sw.WriteLine();
                        break;
                    }

                    for (int i = 0; i < strN.Length; i++)
                    {
                        cal *= (strN[i] - 48);
                    }
                    strN = cal.ToString();
                }
            }
        }
    }
}
