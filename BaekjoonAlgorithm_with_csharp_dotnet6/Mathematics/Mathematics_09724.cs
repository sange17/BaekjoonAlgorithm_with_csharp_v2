namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_09724
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = Int32.Parse(sr.ReadLine()!);

            List<int> list = new List<int>();
            int idx = 1;
            while (true)
            {
                if (idx * idx * idx > 2000000000) break;
                list.Add(idx * idx * idx);
                idx++;
            }

            for (int i = 1; i <= n; i++)
            {
                string line = sr.ReadLine()!;
                int a = Int32.Parse(line.Split(" ")[0]);
                int b = Int32.Parse(line.Split(" ")[1]);
                int count = list.Where(x => x >= a && x <= b).Count();
                sw.WriteLine("Case #" + i + ": " + count);
            }

            sr.Close();
            sw.Close();
        }
    }
}
