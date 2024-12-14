namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_25704
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine()!);
            int P = Int32.Parse(Console.ReadLine()!);

            int stamp = Int32.MaxValue;
            int stamp5 = Int32.MaxValue;
            int stamp10 = Int32.MaxValue;
            int stamp15 = Int32.MaxValue;
            int stamp20 = Int32.MaxValue;

            if (N < 5)
            {
                stamp = P;
            }
            if (N >= 5)
            {
                stamp5 = P - 500 <= 0 ? 0 : P - 500;
            }
            if (N >= 10)
            {
                stamp10 = P - P / 10;
            }
            if (N >= 15)
            {
                stamp15 = P - 2000 <= 0 ? 0 : P - 2000;
            }
            if (N >= 20)
            {
                stamp20 = P - P / 4;
            }

            Console.Write(Math.Min(stamp, Math.Min(stamp5, Math.Min(stamp10, Math.Min(stamp15, stamp20)))));
        }
    }
}
