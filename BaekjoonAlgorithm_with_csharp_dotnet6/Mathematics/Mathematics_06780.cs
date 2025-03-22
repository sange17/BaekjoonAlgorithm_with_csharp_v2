namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_06780
    {
        public void solve()
        {
            int t1 = Int32.Parse(Console.ReadLine()!);
            int t2 = Int32.Parse(Console.ReadLine()!);
            int temp = 0;
            int count = 2;
            
            while (true)
            {   
                if ((t1 - t2) < 0)
                {
                    Console.Write(count);
                    break;
                }

                temp = t1;
                t1 = t2;
                t2 = temp - t2;

                count++;
            }
        }
    }
}
