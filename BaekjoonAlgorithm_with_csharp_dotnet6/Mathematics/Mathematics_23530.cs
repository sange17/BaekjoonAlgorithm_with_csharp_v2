namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_23530
    {
        public void solve()
        {
            int t = Int32.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                string line = Console.ReadLine()!;
                int a = Int32.Parse(line.Split(" ")[0]);
                int b = Int32.Parse(line.Split(" ")[1]);

                Console.WriteLine((a + b) / 2);
            }
        }
    }
}
