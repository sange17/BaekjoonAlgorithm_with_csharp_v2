namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_33515
    {
        /// <summary>
        /// Maht.Min 사용 예제 test
        /// </summary>
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            string line = sr.ReadLine();

            int a = int.Parse(line.Split(" ")[0]);
            int b = int.Parse(line.Split(" ")[1]);

            sw.Write(Math.Min(a, b));

            sr.Close();
            sw.Close();
        }
    }
}
