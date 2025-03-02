using System.Text;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Data_Structures
{
    class Data_Structures_28278
    {
        public void solve()
        {
            Stack<int> stack = new Stack<int>();

            int iter = int.Parse(Console.ReadLine()!);
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < iter; i++)
            {
                //명령 받기
                int[] numbers = Console.ReadLine()!.Trim().Split().Select(x => int.Parse(x)).ToArray();

                switch (numbers[0])
                {
                    case 1://스택에 넣기
                        stack.Push(numbers[1]);
                        break;
                    case 2://pop
                        stringBuilder.Append($"{(stack.Count > 0 ? stack.Pop() : -1)}\n");
                        break;
                    case 3://정수의 개수 출력
                        stringBuilder.Append($"{(stack.Count)}\n");
                        break;
                    case 4://empty
                        stringBuilder.Append($"{(stack.Count > 0 ? 0 : 1)}\n");
                        break;
                    case 5://peek
                        stringBuilder.Append($"{(stack.Count > 0 ? stack.Peek() : -1)}\n");
                        break;
                }
            }
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
