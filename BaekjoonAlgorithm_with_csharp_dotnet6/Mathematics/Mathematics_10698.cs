namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_10698
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = Int32.Parse(sr.ReadLine());

            string[] arr = new string[5];
            for (int i = 0; i < n; i++)
            {
                arr = sr.ReadLine().Split(" ");
                int a = Int32.Parse(arr[0]);
                int b = Int32.Parse(arr[2]);
                int c = Int32.Parse(arr[4]);

                if (arr[1] == "+")
                {
                    if (a + b == c)
                    {
                        sw.WriteLine("Case " + (i + 1) + ": YES");
                    }else
                    {
                        sw.WriteLine("Case " + (i + 1) + ": NO");
                    }
                }
                else if (arr[1] == "-")
                {
                    if (a - b == c)
                    {
                        sw.WriteLine("Case " + (i + 1) + ": YES");
                    }
                    else
                    {
                        sw.WriteLine("Case " + (i + 1) + ": NO");
                    }
                }
            }

            sw.Close();
            sr.Close();
        }
    }
}
