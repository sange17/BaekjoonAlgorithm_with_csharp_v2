using System.ComponentModel.DataAnnotations;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_13063
    {
        public void solve()
        {
            while(true)
            {
                string line = Console.ReadLine()!;
                int n = Int32.Parse(line.Split(" ")[0]);
                int m = Int32.Parse(line.Split(" ")[1]);
                int k = Int32.Parse(line.Split(" ")[2]);
                int o = n - m - k;
                
                if(n == 0 && m == 0 && k == 0) break;

                // 보수 + 혁신 = 총 인원
                if (n == (m + k))
                {
                    if (m > k) Console.WriteLine(0);
                    else Console.WriteLine(-1);
                }
                // 보수 + 혁신 < 총 인원
                else if(n > (m + k))
                {
                    // 보수 + 무소속 <= 혁신
                    if(m + o <= k) Console.WriteLine(-1);
                    // 보수 + 무소속 > 혁신
                    else
                    {
                        // 무소속 표 없이 이기는 경우
                        if(n / 2 < m)
                            Console.WriteLine(0);
                        else
                            Console.WriteLine(n / 2 - m + 1);
                    }
                }
            }
        }
    }
}
