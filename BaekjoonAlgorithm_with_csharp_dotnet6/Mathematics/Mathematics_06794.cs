namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_06794
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);
            if (n < 6)
            {
                Console.Write(n / 2 + 1);
            }
            else if(n == 6)
            {
                Console.Write(3);
            }
            else if (n == 7)
            {
                Console.Write(2);
            }
            else if (n == 8)
            {
                Console.Write(2);
            }
            else if (n == 9)
            {
                Console.Write(1);
            }
            else if (n == 10)
            {
                Console.Write(1);
            }
        }
    }
}
