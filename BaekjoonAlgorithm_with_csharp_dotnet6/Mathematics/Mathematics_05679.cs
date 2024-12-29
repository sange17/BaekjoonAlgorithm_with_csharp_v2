namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_05679
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            while (true)
            {
                int H = Int32.Parse(sr.ReadLine()!);
                if (H == 0)
                {
                    sr.Close();
                    sw.Close();
                }

                int max = H;
                while (H != 1)
                {
                    if (H % 2 == 1)
                    {
                        H = 3 * H + 1;

                        if (max < H) max = H;
                    }
                    else
                    {
                        H /= 2;
                    }
                }

                sw.WriteLine(max);
            }
        }
    }
}
