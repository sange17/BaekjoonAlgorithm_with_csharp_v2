namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_31611
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine());

            if(n == 2)
            {
                Console.WriteLine(1);
            }else
            {
                if(n < 2)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    int m = n - 2;
                    if(m % 7 != 0)
                    {
                        Console.WriteLine(0);
                    }
                    else
                    {
                        Console.WriteLine(1);
                    }
                }
            }
        }
    }
}
