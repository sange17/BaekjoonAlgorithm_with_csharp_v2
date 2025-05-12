namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_27159
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine()!);
            int[] array = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            int sum = 0;
            int min = array[0];

            for (int i = 1; i < N; i++)
            {
                if ((array[i - 1] + 1) < array[i])
                {
                    sum += min;
                    min = array[i];
                }
                else if((array[i - 1] + 1) == array[i])
                {
                    continue;
                }
            }

            Console.Write(sum + min);
        }
    }
}
