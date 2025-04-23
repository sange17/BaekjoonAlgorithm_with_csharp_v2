namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_10395
    {
        public void solve()
        {
            int[] bools1 = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            int[] bools2 = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            bool check = true;

            for (int i = 0; i < bools1.Length; i++)
            {
                if (bools1[i] == bools2[i])
                {
                    check = false;
                    break;
                }
            }

            if (!check)
                Console.Write("N");
            else
                Console.Write("Y");
        }
    }
}
