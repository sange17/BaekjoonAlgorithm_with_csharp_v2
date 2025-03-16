namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_32306
    {
        public void solve()
        {
            int[] array1 = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

            int score1 = array1[0] * 1 + array1[1] * 2 + array1[2] * 3;
            int score2 = array2[0] * 1 + array2[1] * 2 + array2[2] * 3;

            if(score1 > score2)
                Console.Write(1);
            else if(score1 <  score2)
                Console.Write(2);
            else
                Console.Write(0);
        }
    }
}
