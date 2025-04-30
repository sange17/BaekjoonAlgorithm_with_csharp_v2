namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_13871
    {
        public void solve()
        {
            string line = Console.ReadLine()!;
            int N = Int32.Parse(line.Split(" ")[0]);
            int C = Int32.Parse(line.Split(" ")[1]);
            int S = Int32.Parse(line.Split(" ")[2]);
            int[] commands = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            int position = 1;

            int count = 0;

            if (S == 1) count = 1;
            for (int i = 0; i < C; i++)
            {
                if (commands[i] == 1) position++;
                else position--;

                if (position <= 0) position = N;
                if (position == N + 1) position = 1;

                if (position == S) count++;
            }

            Console.Write(count);
        }
    }
}
