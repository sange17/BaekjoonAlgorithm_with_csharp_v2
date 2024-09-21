namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_16785
    {
        public void solve()
        {
            int[] array = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

            int sum = array[2];
            int count = 0;
            int result = 0;
            while (sum >= 0)
            {
                count++;
                result++;

                sum -= array[0];

                if (count == 7)
                {
                    sum -= array[1];
                    count = 0;
                }
            }

            Console.Write(result);

            //int[] array = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

            //int cnt = 0;
            //int total = 0;

            //while (total < array[2])
            //{
            //    total += array[0];
            //    cnt += 1;
            //    if (cnt % 7 == 0) total += array[1];
            //}

            //Console.Write(cnt);
        }
    }
}
