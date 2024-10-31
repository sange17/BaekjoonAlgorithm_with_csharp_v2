namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_02399
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);
            int[] array = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            long sum = 0;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    sum += (Math.Abs(array[i] - array[j])) * 2;
                }
            }

            Console.Write(sum);
        }
    }
}
