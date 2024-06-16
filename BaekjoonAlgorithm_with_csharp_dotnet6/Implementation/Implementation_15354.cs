namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_15354
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine());

            int count = 1;
            string current = Console.ReadLine();
            for (int i = 0; i < n - 1; i++)
            {
                string next = Console.ReadLine();

                if (current == next) continue;
                else count++;

                current = next;
            }

            Console.Write(count + 1);
        }
    }
}
