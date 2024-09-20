namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_16785
    {
        public void solve()
        {
            int[] array = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

            int cnt = 0;
            int total = 0;

            while (total < array[2])
            {
                total += array[0];
                cnt += 1;
                if (cnt % 7 == 0) total += array[1];
            }
            
            Console.Write(cnt);
        }
    }
}
