namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_21875
    {
        public void solve()
        {
            string A = Console.ReadLine()!;
            string B = Console.ReadLine()!;

            int x = Math.Abs(A[0] - B[0]);
            int y = Math.Abs(A[1] - B[1]);

            if(x > y)
                Console.Write(y + " " + x);
            else
                Console.Write(x + " " + y);

        }
    }
}
