namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_05292
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine("Dead");
                }
                else if(i % 3 != 0 && i % 5 == 0)
                {
                    Console.WriteLine("Man");
                }
                else if(i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("DeadMan");
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
