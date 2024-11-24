namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_01440
    {
        public void solve()
        {
            int[] array = Console.ReadLine()!.Split(":").Select(int.Parse).ToArray();
            int count = 0;

            if (array[0] > 59 || array[1] > 59 || array[2] > 59)
            {
                Console.Write(count);
            }
            else
            {
                if (array[0] > 0 && array[0] <= 12)
                    count += 2;
                if (array[1] > 0 && array[1] <= 12)
                    count += 2;
                if (array[2] > 0 && array[2] <= 12)
                    count += 2;

                Console.Write(count);
            }
        }
    }
}
