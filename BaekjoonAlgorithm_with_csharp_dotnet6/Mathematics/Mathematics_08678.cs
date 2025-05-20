namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_08678
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

            int n = Int32.Parse(sr.ReadLine()!);
            int[] array = new int[2];

            for (int i = 0; i < n; i++)
            {
                array = sr.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

                if (array[1] % array[0] == 0) sw.WriteLine("TAK");
                else sw.WriteLine("NIE");
            }

            sr.Close();
            sw.Close();
        }
    }
}
