namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_33166
    {
        public void solve()
        {
            int[] inputs1 = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            int[] inputs2 = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

            int P = inputs1[0];
            int Q = inputs1[1];
            int A = inputs2[0];
            int B = inputs2[1];

            if(P <= Q)
                Console.Write((P * A) + (Q - P) * B);
            else
                Console.Write(Q * A);
        }
    }
}
