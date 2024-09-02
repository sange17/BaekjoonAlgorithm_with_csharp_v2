namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_13617
    {
        public void solve()
        {
            string line = Console.ReadLine()!;
            int n = Int32.Parse(line.Split(' ')[0]);
            int m = Int32.Parse(line.Split(' ')[1]);

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                int[] array = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                if (!array.Contains(0)) count++;
            }

            Console.Write(count);
        }
    }
}
