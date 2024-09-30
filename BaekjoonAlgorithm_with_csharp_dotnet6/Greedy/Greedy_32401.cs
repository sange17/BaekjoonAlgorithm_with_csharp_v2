namespace BaekjoonAlgorithm_with_csharp_dotnet6.Greedy
{
    class Greedy_32401
    {
        public void solve()
        {
            int n = int.Parse(Console.ReadLine()!);
            string line = Console.ReadLine()!;

            bool a1 = false;
            bool n1 = false;
            bool a2 = false;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (line[i] == 'A' && !a1)
                    a1 = true;
                else if (line[i] == 'N' && a1 && !n1)
                    n1 = true;
                else if (line[i] == 'A' && a1 && n1 && !a2)
                    a2 = true;

                if (a1 && n1 && a2)
                {
                    count++;
                    a1 = true;
                    n1 = false;
                    a2 = false;
                }
            }

            Console.Write(count);
        }
    }
}