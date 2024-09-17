namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_08661
    {
        public void solve()
        {
            int[] array = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

            int steps = array[0] + 1;
            while (true)
            {
                steps -= array[1];
                if (steps <= 0)
                {
                    Console.Write(1);
                    break;
                }

                steps -= array[2];
                if (steps <= 0)
                {
                    Console.Write(0);
                    break;
                }
            }
        }
    }
}
