namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
     class Implementation_27325
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);
            string line = Console.ReadLine()!;

            int position = 1;
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                if (line[i] == 'L')
                {
                    position--;
                    if (position < 1)
                    {
                        position = 1;
                        continue;
                    }
                }
                else if (line[i] == 'R')
                {
                    position++;
                    if (position >= 3)
                    {
                        position = 3;
                        result++;
                        continue;
                    }
                }
            }

            Console.Write(result);
        }
    }
}
