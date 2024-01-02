using System;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_29863
    {
        public void solve()
        {
            int H1 = Int32.Parse(Console.ReadLine());
            int H2 = Int32.Parse(Console.ReadLine());

            if(H1 > 3)
            {
                Console.Write((24 - H1) + H2);
            }
            else
            {
                Console.Write(H2 - H1);
            }
        }
    }
}
