namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_11257
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int N = Int32.Parse(sr.ReadLine());
            string line = string.Empty;
            string stuNo = string.Empty;
            double strategy = 0.0;
            double management = 0.0;
            double technology = 0.0;
            double strategyLimit = 35.0 * 30.0 / 100.0;
            double managementLimit = 25.0 * 30.0 / 100.0;
            double technologyLimit = 40.0 * 30.0 / 100.0;
            double sum = 0;
            for (int i = 0; i < N; i++)
            {
                line = sr.ReadLine();
                stuNo = line.Split(" ")[0];
                strategy = Int32.Parse(line.Split(" ")[1]);
                management = Int32.Parse(line.Split(" ")[2]);
                technology = Int32.Parse(line.Split(" ")[3]);

                sum = strategy + management + technology;

                if(sum >= 55 && strategyLimit <= strategy && managementLimit <= management && technologyLimit <= technology)
                {
                    sw.WriteLine(stuNo + " " + sum + " " + "PASS");
                }
                else
                {
                    sw.WriteLine(stuNo + " " + sum + " " + "FAIL");
                }

                sum = 0;
            }

            sr.Close();
            sw.Close();
        }
    }
}
