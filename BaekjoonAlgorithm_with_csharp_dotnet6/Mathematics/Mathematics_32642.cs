namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_32642
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine()!);
            int[] array = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

            long angry = 0;
            long result = 0;
            
            for (int i = 0; i < N; i++)
            {
                if (array[i] == 1) angry++;
                else angry--;

                result += angry;
            }

            Console.Write(result);
        }
    }
}
