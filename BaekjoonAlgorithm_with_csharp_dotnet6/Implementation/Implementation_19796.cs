namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_19796
    {
        public void solve()
        {
            string line = Console.ReadLine()!;
            int m = Int32.Parse(line.Split(" ")[0]);
            int n = Int32.Parse(line.Split(" ")[1]);
            bool[] array = new bool[m];

            for (int i = 0; i < n; i++)
            {
                line = Console.ReadLine()!;
                int l = Int32.Parse(line.Split(' ')[0]);
                int r = Int32.Parse(line.Split(' ')[1]);

                for (int j = l - 1; j <= r - 1; j++)
                {
                    array[j] = true;
                }
            }

            if(array.Contains(false))
                Console.Write("NO");
            else
                Console.Write("YES");
        }
    }
}
