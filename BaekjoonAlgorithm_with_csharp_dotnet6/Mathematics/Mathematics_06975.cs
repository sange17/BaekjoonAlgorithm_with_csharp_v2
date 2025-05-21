namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_06975
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = Int32.Parse(sr.ReadLine()!);
            int num = 0;
            for (int i = 0; i < n; i++)
            {
                num = Int32.Parse(sr.ReadLine()!);

                int sum = 0;
                for (int j = 1; j < num; j++)
                {
                    if (num % j == 0) sum += j;
                }

                if (sum < num)
                    sw.WriteLine(num + " is a deficient number.");
                else if (sum == num)
                    sw.WriteLine(num + " is a perfect number.");
                else if (sum > num)
                    sw.WriteLine(num + " is an abundant number.");

                if (i != n - 1) sw.WriteLine();
            }

            sr.Close();
            sw.Close();
        }
    }
}
