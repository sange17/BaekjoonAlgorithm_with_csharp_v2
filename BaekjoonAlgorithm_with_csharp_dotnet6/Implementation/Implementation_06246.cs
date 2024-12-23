namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_06246
    {
        public void solve()
        {
            string line = Console.ReadLine()!;
            int N = Int32.Parse(line.Split(" ")[0]);
            int Q = Int32.Parse(line.Split(" ")[1]);

            bool[] array = new bool[N + 1];
            for (int i = 0; i < Q; i++)
            {
                line = Console.ReadLine()!;
                int L = Int32.Parse(line.Split(" ")[0]);
                int I = Int32.Parse(line.Split(" ")[1]);
                int index = L;
                while (true)
                {
                    if (index >= array.Length) break;

                    array[index] = true;
                    index += I;
                }
            }

            // 0번째 인덱스 값 제외
            Console.Write(array.Where(x => x == false).Count() - 1);
        }
    }
}
