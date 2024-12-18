namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_05367
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = Int32.Parse(Console.ReadLine()!);

            sw.Write("|");
            for (int i = 0; i < n - 2; i++)
                sw.Write("-");
            sw.WriteLine("|");

            int left = 1;
            int right = n - 2;
            for (int i = 0; i < n - 2; i++)
            {
                sw.Write("|");
                for (int j = 1; j < n - 1; j++)
                {
                    if(j == left || j == right) sw.Write("*");
                    else sw.Write(" ");
                }
                sw.WriteLine("|");

                left++;
                right--;
            }

            sw.Write("|");
            for (int i = 0; i < n - 2; i++)
                sw.Write("-");
            sw.Write("|");

            sr.Close();
            sw.Close();
        }
    }
}
