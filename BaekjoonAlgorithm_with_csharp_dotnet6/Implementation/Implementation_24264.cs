using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_24264
    {
        public void solve()
        {
            //MenOfPassion(A[], n) {
            //    sum < -0;
            //    for i < -1 to n
            //        for j < -1 to n
            //            sum < -sum + A[i] × A[j]; # 코드1
            //    return sum;
            //}
            // 주석 처리한 위의 알고리즘은 중첩 for문이므로 n * n의 결과 즉 시간 복잡도는 O(n^2)이다.

            long N = long.Parse(Console.ReadLine());
            Console.WriteLine(N * N);
            Console.WriteLine(2);
        }
    }
}
