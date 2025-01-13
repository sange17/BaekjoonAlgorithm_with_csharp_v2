namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_15080
    {
        public void solve()
        {
            int[] time1 = Console.ReadLine()!.Split(" : ").Select(int.Parse).ToArray();
            int[] time2 = Console.ReadLine()!.Split(" : ").Select(int.Parse).ToArray();

            int s1 = time1[0] * 3600 + time1[1] * 60 + time1[2];
            int s2= time2[0] * 3600 + time2[1] * 60 + time2[2];

            if(s1 > s2)
                Console.Write(s2 - s1 + 3600 * 24);
            else
                Console.Write(s2 - s1);
        }
    }
}
