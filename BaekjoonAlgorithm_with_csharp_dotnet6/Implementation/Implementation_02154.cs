using System.Text;

namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_02154
    {
        //string의 경우 가변처럼 작동하는 거 같지만 사실 내부적으로는 매번 메모리 할당이 일어나고 있다. 그래서 string을 매우 많이 변경하면 메모리에 오버헤드가 발생하게 된다.
        //stringbuilder를 사용하여 가변으로 작동되도록 사용할 것
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine()!);

            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 1; i <= N; i++)
            {
                stringBuilder.Append(i);
            }

            Console.Write(stringBuilder.ToString().IndexOf(N.ToString()) + 1);
        }
    }
}
