namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Mathematics_33515
    {
        /// <summary>
        /// 
        /// </summary>
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string line = sr.ReadLine();

            int a = Int32.Parse(line.Split(" ")[0]);
            int b = Int32.Parse(line.Split(" ")[1]);

            sw.Write(Math.Min(a, b));

            sr.Close();
            sw.Close();
        }
    }
}
