namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_26772
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = Int32.Parse(sr.ReadLine()!);
            for (int i = 0; i < n; i++) sw.Write(" @@@   @@@  ");
            sw.WriteLine();
            for (int i = 0; i < n; i++) sw.Write("@   @ @   @ ");
            sw.WriteLine();
            for (int i = 0; i < n; i++) sw.Write("@    @    @ ");
            sw.WriteLine();
            for (int i = 0; i < n; i++) sw.Write("@         @ ");
            sw.WriteLine();
            for (int i = 0; i < n; i++) sw.Write(" @       @  ");
            sw.WriteLine();
            for (int i = 0; i < n; i++) sw.Write("  @     @   ");
            sw.WriteLine();
            for (int i = 0; i < n; i++) sw.Write("   @   @    ");
            sw.WriteLine();
            for (int i = 0; i < n; i++) sw.Write("    @ @     ");
            sw.WriteLine();
            for (int i = 0; i < n; i++) sw.Write("     @      ");
            sw.WriteLine();

            sr.Close();
            sw.Close();
        }
    }
}
