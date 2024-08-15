namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_13073
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int N = Int32.Parse(sr.ReadLine()!);

            for (int i = 0; i < N; i++)
            {
                int num = Int32.Parse(sr.ReadLine()!);
                int sum = 0;

                for (int j = 1; j <= num; j++)
                {
                    sum += j;
                }

                sw.WriteLine(sum + " " + (num * num) + " " + (num * num + num));
            }

            sr.Close();
            sw.Close();
        }
    }
}
