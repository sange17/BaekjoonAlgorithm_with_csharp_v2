namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_13129
    {
        public void solve()
        {
            string line = Console.ReadLine()!;
            int A = Int32.Parse(line.Split(" ")[0]);
            int B = Int32.Parse(line.Split(" ")[1]);
            int N = Int32.Parse(line.Split(" ")[2]);

            int structure = A * N + B;
            Console.Write(structure + " ");
            for (int i = 0; i < N - 1; i++)
            {
                structure += B;
                Console.Write(structure + " ");
            }
        }
    }
}
