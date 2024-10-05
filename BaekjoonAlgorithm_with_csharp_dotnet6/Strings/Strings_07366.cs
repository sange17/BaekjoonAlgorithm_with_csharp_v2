namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_07366
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int t = Int32.Parse(sr.ReadLine()!);
            for (int i = 1; i <= t; i++)
            {
                int n = Int32.Parse(sr.ReadLine()!);
                int count = 0;
                string[] array = sr.ReadLine()!.Split(" ").ToArray();
                for (int j = 0; j < n; j++)
                {
                    if (array[j] == "sheep") count++;
                }

                sw.WriteLine("Case " + i + ": This list contains " + count + " sheep.");
                sw.WriteLine();
            }

            sr.Close();
            sw.Close();
        }
    }
}
