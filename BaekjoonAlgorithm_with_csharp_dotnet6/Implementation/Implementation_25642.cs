namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    internal class Implementation_25642
    {
        public void solve()
        {
            int[] inputs = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            int ytSum = inputs[0];
            int yjSum = inputs[1];
            bool turn = false;
            while (true)
            {
                if (ytSum >= 5)
                {
                    Console.Write("yj");
                    break;
                }
                else if (yjSum >= 5)
                {
                    Console.Write("yt");
                    break;
                }

                if (turn)
                {
                    ytSum += yjSum;
                    turn = false;
                }
                else
                {
                    yjSum += ytSum;
                    turn = true;
                }
            }
         }
    }
}
