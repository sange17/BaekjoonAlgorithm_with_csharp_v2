namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_09848
    {
        public void solve()
        {
            string line = Console.ReadLine();
            int n = Int32.Parse(line.Split(" ")[0]);
            int k = Int32.Parse(line.Split(" ")[1]);

            int count = 0;
            int before = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)
            {
                int current = Int32.Parse(Console.ReadLine());

                if (before - current >= k) count++;

                before = current;
            }

            Console.Write(count);
        }
    }
}
