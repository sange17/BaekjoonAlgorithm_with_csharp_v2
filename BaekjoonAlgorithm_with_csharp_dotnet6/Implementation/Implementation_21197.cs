namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_21197
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);
            bool flag = false;
            int startT = 0;
            int endT = 0;
            int sum = 0;

            if (n % 2 != 0)
            {
                Console.Write("still running");
                return;
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (flag)
                    {
                        endT = Int32.Parse(Console.ReadLine()!);
                        sum += endT - startT;
                        flag = false;
                    }
                    else
                    {
                        startT = Int32.Parse(Console.ReadLine()!);
                        flag = true;
                    }
                }
            }

            Console.Write(sum);
        }
    }
}
