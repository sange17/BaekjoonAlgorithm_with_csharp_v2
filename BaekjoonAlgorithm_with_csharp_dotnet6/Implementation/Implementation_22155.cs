namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_22155
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine());
            string line = string.Empty;
            for(int j = 0; j < n; j++)
            {
                line = Console.ReadLine();
                int i = Int32.Parse(line.Split(" ")[0]);
                int f = Int32.Parse(line.Split(" ")[1]);

                if ((i <= 1 && f <= 2) || (i <= 2 && f <= 1))
                    Console.WriteLine("Yes");
                else
                    Console.WriteLine("No");
            }
        }
    }
}
