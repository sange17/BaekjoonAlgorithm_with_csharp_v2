using System.Text;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_05357
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine());
            string line = string.Empty;
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < N; i++)
            {
                line = Console.ReadLine();
                Queue<char> queue = new Queue<char>();
                queue.Enqueue(line[0]);
                for(int j = 1; j < line.Length; j++)
                {
                    if(queue.Last() != line[j])
                    {
                        queue.Enqueue(line[j]);
                    }
                }

                while(queue.Count > 0)
                {
                    sb.Append(queue.Dequeue());
                }
                
                sb.Append("\n");
            }

            Console.Write(sb.ToString());
        }
    }
}
