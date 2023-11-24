using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_27239
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine());

            char a = (char)(96 + (n % 8 == 0 ? 8 : n % 8));
            int b = n % 8 != 0 ? n / 8 + 1 : n / 8;

            Console.Write(a + "" + b);
        }
    }
}
