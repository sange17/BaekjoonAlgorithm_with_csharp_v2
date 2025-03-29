namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_32684
    {
        public void solve()
        {
            int[] cho = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            int[] han = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

            double choScore = cho[0] * 13 + cho[1] * 7 + cho[2] * 5 + cho[3] * 3 + cho[4] * 3 + cho[5] * 2;
            double hanScore = han[0] * 13 + han[1] * 7 + han[2] * 5 + han[3] * 3 + han[4] * 3 + han[5] * 2 + 1.5;

            if (choScore > hanScore)
            {
                Console.Write("cocjr0208");
            }
            else
            {
                Console.Write("ekwoo");
            }
        }
    }
}
