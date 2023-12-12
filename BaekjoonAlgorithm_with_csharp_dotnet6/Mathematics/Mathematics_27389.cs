using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_27389
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine());

            var num = (double) N / 4.0;

            Console.WriteLine(String.Format("{0:0.###}", num));
        }
    }
}
