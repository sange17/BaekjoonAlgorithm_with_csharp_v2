namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_06903
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int t = Int32.Parse(sr.ReadLine()!);
            int s = Int32.Parse(sr.ReadLine()!);
            int h = Int32.Parse(sr.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                sw.Write("*");
                for (int j = 0; j < s; j++)
                    sw.Write(" ");
                sw.Write("*");
                for (int j = 0; j < s; j++)
                    sw.Write(" ");
                sw.Write("*");
                sw.WriteLine();
            }

            for (int i = 0; i < s * 2 + 3; i++)
                sw.Write("*");

            sw.WriteLine();

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < s + 1; j++)
                    sw.Write(" ");
                sw.Write("*");
                sw.WriteLine();
            }

            sr.Close();
            sw.Close();
        }
    }
}
