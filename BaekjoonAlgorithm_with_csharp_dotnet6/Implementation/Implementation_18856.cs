namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_18856
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = Int32.Parse(sr.ReadLine()!);

            sw.WriteLine(n);
            sw.Write("1 2 ");

            for(int i = 0; i < n - 3; i++)
            {
                sw.Write((3 + i) + " ");
            }

            sw.Write(53);

            sr.Close();
            sw.Close();
        }
    }
}
