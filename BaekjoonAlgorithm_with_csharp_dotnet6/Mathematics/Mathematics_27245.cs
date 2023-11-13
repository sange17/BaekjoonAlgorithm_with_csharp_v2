using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_27245
    {
        public void solve()
        {
            int w = Int32.Parse(Console.ReadLine());
            int l = Int32.Parse(Console.ReadLine());
            int h = Int32.Parse(Console.ReadLine());

            int min = Math.Min(w, l);
            int max = Math.Max(w, l);
            if(min / h >= 2 && max / min <= 2)
            {
                Console.Write("good");
            }
            else
            {
                Console.Write("bad");
            }
        }
    }
}
