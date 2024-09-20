namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_23972
    {
        public void solve()
        {
            long[] array = Console.ReadLine()!.Split(" ").Select(long.Parse).ToArray();

            if (array[1] == 1)
            {
                Console.Write(-1);
            }
            else
            {
                long nmulk = array[0] * array[1];
                long nmink = array[1] - 1;
                long x = nmulk / nmink;

                // 악마와 거래한 돈 > 처음에 소지한 돈
                if ((x - array[0]) * array[1] < x)
                    Console.Write(x + array[0]);
                // 악마와 거래한 돈 <= 처음에 소지한 돈
                else 
                    Console.Write(x);
            }
        }
    }
}
