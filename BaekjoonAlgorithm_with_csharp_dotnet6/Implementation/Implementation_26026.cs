namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_26026
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);

            string line = Console.ReadLine()!;
            int count = 0;
            int coffee = 0;
            for (int i = 0; i < n; i++)
            {
                if (line[i] == '1')
                {
                    coffee = 2;
                    count++;
                }
                else
                {
                    if (coffee == 0)
                    {
                        coffee = 0;
                    }
                    else if (coffee > 0)
                    {
                        coffee--;
                        count++;
                    }
                }
            }

            Console.Write(count);
        }
    }
}
