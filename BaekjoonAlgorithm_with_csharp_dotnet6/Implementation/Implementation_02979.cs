namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_02979
    {
        public void solve()
        {
            int[] abcArray = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            int[] array = new int[101];

            for (int i = 0; i < 3; i++)
            {
                int[] time = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
                for (int j = time[0]; j < time[1]; j++)
                {
                    array[j]++;
                }
            }

            int result = 0;
            for (int i = 1; i < 101; i++)
            {
                if (array[i] == 1)
                    result += abcArray[0];
                else if (array[i] == 2)
                    result += abcArray[1] * 2;
                else if (array[i] == 3)
                    result += abcArray[2] * 3;
            }

            Console.Write(result);
        }
    }
}
