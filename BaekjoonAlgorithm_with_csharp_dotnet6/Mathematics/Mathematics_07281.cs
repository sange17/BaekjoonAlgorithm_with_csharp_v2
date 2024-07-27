namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_07281
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);

            List<int> list = new List<int>();

            int time1 = 0;
            int time2 = 0;
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine()!;

                int t = Int32.Parse(line.Split(" ")[0]);
                int m = Int32.Parse(line.Split(" ")[1]);

                if(m == 1) list.Add(t);
            }

            int pre = list[0];
            int max = 0;
            for (int i = 1; i < list.Count; i++)
            {
                if (max < list[i] - pre)
                {
                    max = list[i] - pre;
                }
                pre = list[i];
            }

            Console.Write(max);
        }
    }
}
