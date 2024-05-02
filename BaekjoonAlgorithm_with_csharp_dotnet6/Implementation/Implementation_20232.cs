namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_20232
    {
        public void solve()
        {
            string[] array = { "ITMO", "SPbSU", "SPbSU", "ITMO", "ITMO",
                               "SPbSU", "ITMO", "ITMO", "ITMO", "ITMO",
                               "ITMO", "PetrSU, ITMO", "SPbSU", "SPbSU", "ITMO",
                               "ITMO", "ITMO", "ITMO", "SPbSU", "ITMO",
                               "ITMO", "ITMO", "ITMO", "SPbSU", "ITMO",};

            int n = Int32.Parse(Console.ReadLine());

            Console.WriteLine(array[n - 1995]);
        }
    }
}
