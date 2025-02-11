namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_31609
    {
        public void solve()
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int N = Int32.Parse(sr.ReadLine()!);
            int[] array = sr.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            Array.Sort(array);

            int pre = -1;
            for (int i = 0; i < N; i++)
            {
                if (pre == array[i]) continue;
                sw.WriteLine(array[i]);
                pre = array[i];
            }

            sr.Close();
            sw.Close();
        }
    }
}
