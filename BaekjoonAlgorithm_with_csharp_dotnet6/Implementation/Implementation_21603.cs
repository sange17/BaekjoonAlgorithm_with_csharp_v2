using System.Text;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_21603
    {
        public void solve()
        {
            var input = Console.ReadLine()!.Split();
            var n = int.Parse(input[0]);
            var k = int.Parse(input[1]);

            var modK = k % 10;
            var mod2K = (2 * k) % 10;

            var res = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                if (i % 10 != modK && i % 10 != mod2K)
                    res.Add(i);
            }

            var sb = new StringBuilder();
            sb.AppendLine(res.Count.ToString());
            foreach (var num in res)
                sb.Append(num + " ");

            Console.Write(sb.ToString());
        }
    }
}
