namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_29699
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine());

            if (n % 14 == 1)
            {
                Console.WriteLine("W");
            }
            else if (n % 14 == 2 || n % 14 == 7)
            {
                Console.WriteLine("e");
            }
            else if (n % 14 == 3)
            {
                Console.WriteLine("l");
            }
            else if (n % 14 == 4)
            {
                Console.WriteLine("c");
            }
            else if (n % 14 == 5 || n % 14 == 9)
            {
                Console.WriteLine("o");
            }
            else if (n % 14 == 6)
            {
                Console.WriteLine("m");
            }
            else if (n % 14 == 8)
            {
                Console.WriteLine("T");
            }
            else if (n % 14 == 10)
            {
                Console.WriteLine("S");
            }
            else if (n % 14 == 11)
            {
                Console.WriteLine("M");
            }
            else if (n % 14 == 12)
            {
                Console.WriteLine("U");
            }
            else if (n % 14 == 13)
            {
                Console.WriteLine("P");
            }
            else if (n % 14 == 0)
            {
                Console.WriteLine("C");
            }
        }
    }
}
