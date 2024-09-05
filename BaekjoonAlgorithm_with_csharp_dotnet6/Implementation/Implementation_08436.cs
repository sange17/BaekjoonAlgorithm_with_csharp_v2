namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_08436
    {
        public void solve()
        {
            string line = Console.ReadLine()!;

            int result = 1;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == 'L' || line[i] == 'F')
                    result *= 2;
                else
                    result *= 1;
            }

            Console.Write(result);
        }
    }
}