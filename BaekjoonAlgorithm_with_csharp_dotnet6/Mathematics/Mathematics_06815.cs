namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_06815
    {
        // 제곱수와 세제곱수의 최소 공배수(LCM)
        public void solve()
        {
            int a = Int32.Parse(Console.ReadLine()!);
            int b = Int32.Parse(Console.ReadLine()!);

            int count = 0;
            for (int i = 1; i * i * i * i * i * i <= b; i++)
                if (i * i * i * i * i * i >= a) count++;

            Console.Write(count);
        }
    }
}
