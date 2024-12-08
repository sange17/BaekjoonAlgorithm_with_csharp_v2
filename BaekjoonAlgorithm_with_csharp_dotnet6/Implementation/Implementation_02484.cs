namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_02484
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = Int32.Parse(sr.ReadLine()!);

            int max = 0;
            for (int i = 0; i < n; i++)
            {
                int[] array = new int[7];
                int[] nums = sr.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
                int calValue = 0;
                for (int j = 0; j < 4; j++) array[nums[j]]++;

                if (array.Max() == 4)
                {
                    calValue = 50000 + Array.IndexOf(array, 4) * 5000;
                }
                else if (array.Max() == 3)
                {
                    calValue = 10000 + Array.IndexOf(array, 3) * 1000;
                }
                else if (array.Where(x => x == 2).Count() == 2)
                {
                    calValue = 2000 + Array.IndexOf(array, 2) * 500 + Array.LastIndexOf(array, 2) * 500;
                }
                else if (array.Max() == 2)
                {
                    calValue = 1000 + Array.IndexOf(array, 2) * 100;
                }
                else if (array.Where(x => x == 1).Count() == 4)
                {
                    calValue = Array.LastIndexOf(array, 1) * 100;
                }

                if (max < calValue) max = calValue;
            }

            sw.Write(max);
            sr.Close();
            sw.Close();
        }
    }
}
