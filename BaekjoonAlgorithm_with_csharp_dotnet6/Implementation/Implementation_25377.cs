namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_25377
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine());
            string line = string.Empty;
            int cnt = 0;
            int min = 1001;
            for(int i = 0; i < N; i++)
            {
                line = Console.ReadLine();
                int A = Int32.Parse(line.Split(" ")[0]);
                int B = Int32.Parse(line.Split(" ")[1]);

                if (A > B)
                    continue;
                else
                {
                    if(min > B)
                    {
                        min = B;
                        cnt++;
                    }    
                }
            }

            if(cnt == 0)
                Console.Write(-1);
            else
                Console.Write(min);
        }
    }
}
