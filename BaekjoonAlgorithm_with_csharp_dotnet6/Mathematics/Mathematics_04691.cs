namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_04691
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string line = string.Empty;
            while(true)
            {
                line = sr.ReadLine();
                int B = Int32.Parse(line.Split(" ")[0]);
                int N = Int32.Parse(line.Split(" ")[1]);

                if(B == 0 && N == 0)
                {
                    sr.Close();
                    sw.Close();
                    break;
                }

                int left = 0;
                int right = 0;
                for (int i = 1; i <= B; i++)
                { 
                    if(B <= Math.Pow(i, N))
                    {
                        right = i;
                        left = right - 1;
                        sw.WriteLine((B - Math.Pow(left, N) < Math.Pow(right, N) - B) ? left : right);
                        break;
                    }
                }
            }
        }
    }
}
