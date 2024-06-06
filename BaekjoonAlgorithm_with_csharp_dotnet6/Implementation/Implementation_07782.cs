namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_07782
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            int ax = Int32.Parse(line.Split(" ")[0]);
            int ay = Int32.Parse(line.Split(" ")[1]);

            int flag = 0;
            for (int i = 0; i < n; i++)
            {
                line = Console.ReadLine();
                int lx = Int32.Parse(line.Split(" ")[0]);
                int ly = Int32.Parse(line.Split(" ")[1]);
                int hx = Int32.Parse(line.Split(" ")[2]);
                int hy = Int32.Parse(line.Split(" ")[3]);
            
                if(lx <= ax && hx >= ax && ly <= ay && hy >= ay)
                {
                    flag = 1;
                    break;
                }
            }

            if(flag == 0)
                Console.Write("No");
            else
                Console.Write("Yes");
        }
    }
}
