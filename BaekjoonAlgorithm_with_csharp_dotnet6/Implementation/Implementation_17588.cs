using System.Text;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_17588
    {
        public void solve()
        {
            StringBuilder sb = new StringBuilder();

            int n = Int32.Parse(Console.ReadLine()!);
            int[] array = new int[n + 1];

            for (int i = 1; i <= n; i++)
            {
                array[i] = Int32.Parse(Console.ReadLine()!);
            }

            bool[] checkArray = new bool[array[n] + 1];

            for (int i = 1; i <= array.Length - 1; i++)
            {
                checkArray[array[i]] = true;
            }

            bool flag = false;
            for (int i = 1; i <= checkArray.Length - 1; i++)
            {
                if (!checkArray[i]) sb.Append(i + "\n");
            }

            if(sb.Length == 0)
            {
                Console.Write("good job");
            }
            else
            {
                Console.Write(sb.ToString());
            }
        }
    }
}
