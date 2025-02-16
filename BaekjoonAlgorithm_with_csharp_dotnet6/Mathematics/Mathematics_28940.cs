namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_28940
    {
        public void solve()
        {
            string line = Console.ReadLine()!;
            int w = Int32.Parse(line.Split(" ")[0]);
            int h = Int32.Parse(line.Split(" ")[1]);
            line = Console.ReadLine()!;
            int n = Int32.Parse(line.Split(" ")[0]);
            int a = Int32.Parse(line.Split(" ")[1]);
            int b = Int32.Parse(line.Split(" ")[2]);

            int wCnt = w / a;
            int hCnt = h / b;

            if (wCnt > 0 && hCnt > 0)
            {
                if (n % (wCnt * hCnt) == 0)
                {
                    Console.Write(n / (wCnt * hCnt));
                }
                else if (n % (wCnt * hCnt) != 0)
                {
                    Console.Write(n / (wCnt * hCnt) + 1);
                }
            }
            else
            {
                Console.Write(-1);
            }
        }
    }
}
