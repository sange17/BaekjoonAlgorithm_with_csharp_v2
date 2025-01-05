namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_10406
    {
        public void solve()
        {
            string line = Console.ReadLine()!;
            int W = Int32.Parse(line.Split(" ")[0]);
            int N = Int32.Parse(line.Split(" ")[1]);
            int P = Int32.Parse(line.Split(" ")[2]);

            int[] array = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            int count = 0;
            for (int i = 0; i < P; i++)
                if (array[i] >= W && array[i] <= N) count++;

            Console.Write(count);
        }
    }
}
