namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_21022
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);
            int[] team1 = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            int[] team2 = Console.ReadLine()!.Split().Select(int.Parse).ToArray(); ;

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (team1[i] > team2[i])
                {
                    sum += 3;
                }
                else if (team1[i] == team2[i])
                {
                    sum += 1;
                }
            }

            Console.Write(sum);
        }
    }
}
