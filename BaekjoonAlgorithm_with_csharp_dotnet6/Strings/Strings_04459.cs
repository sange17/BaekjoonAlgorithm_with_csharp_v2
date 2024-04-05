namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_04459
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int q = Int32.Parse(sr.ReadLine());
            string[] rules = new string[q + 1];
            for(int i = 1; i < q + 1; i++)
            {
                rules[i] = sr.ReadLine();
            }

            int r = Int32.Parse(sr.ReadLine());
            for(int i = 0; i < r; i++)
            {
                int num = Int32.Parse(sr.ReadLine());
                if(num < 1 || num > q)
                {
                    sw.WriteLine("Rule " + num + ": No such rule");
                }
                else
                {
                    sw.WriteLine("Rule " + num + ": " + rules[num]);
                }
            }
            sr.Close();
            sw.Close();
        }
    }
}
