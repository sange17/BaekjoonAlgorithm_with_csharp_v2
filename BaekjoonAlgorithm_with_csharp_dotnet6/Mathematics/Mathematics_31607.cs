namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_31607
    {
        public void solve()
        {
            int A = Int32.Parse(Console.ReadLine()!);
            int B = Int32.Parse(Console.ReadLine()!);
            int C = Int32.Parse(Console.ReadLine()!);
            if(A + B == C || A + C == B || B + C == A)
                Console.Write(1);
            else 
                Console.Write(0);
        }
    }
}
