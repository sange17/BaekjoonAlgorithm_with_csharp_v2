namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_21212
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine()!);

            int min = int.MaxValue;
            for (int i = 0; i < N; i++)
            {
                int[] array = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

                if (array[1] / array[0] < min)
                {
                    min = array[1] / array[0];
                }
            }

            Console.Write(min);
        }
    }
}
