using System.Text;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Greedy
{
    class Greedy_02812
    {
        public void solve()
        {
            string line = Console.ReadLine();
            int N = Int32.Parse(line.Split(' ')[0]);
            int K = Int32.Parse(line.Split(' ')[1]);
            int len = N - K;
            Stack<Char> stack = new Stack<Char>();
            StringBuilder sb = new StringBuilder();

            line = Console.ReadLine();

            for(int i = 0; i < line.Length; i++)
            {
                if(stack.Count > 0)
                {
                    while(stack.Count > 0 && K > 0 && stack.Peek() < line[i])
                    {
                        stack.Pop();
                        K--;
                    }
                }

                stack.Push(line[i]);
            }


            while(true)
            {
                if(stack.Count() == len) break;

                stack.Pop();
            }

            while(stack.Count > 0)
            {
                sb.Append(stack.Pop());
            }

            line = sb.ToString();
            sb.Clear();
            for(int i = line.Length - 1; i >= 0; i--)
            {
                sb.Append(line[i]);
            }

            Console.Write(sb.ToString());
        }
    }
}
