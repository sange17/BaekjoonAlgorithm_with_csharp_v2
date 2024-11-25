namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_01871
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine()!);
            for (int i = 0; i < N; i++)
            {
                string[] array = Console.ReadLine()!.Split("-");
                int first = array[0][0] - 65;
                int second = array[0][1] - 65;
                int third = array[0][2] - 65;
                int front = first * 26 * 26 + second * 26 + third;
                int back = Convert.ToInt32(array[1]);

                if (Math.Abs(front - back) <= 100)
                {
                    Console.WriteLine("nice");
                }
                else
                {
                    Console.WriteLine("not nice");
                }
            }
        }
    }
}
