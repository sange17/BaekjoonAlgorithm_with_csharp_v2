namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_01731
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine()!);

            int num1 = Int32.Parse(Console.ReadLine()!);
            int num2 = Int32.Parse(Console.ReadLine()!);

            int num = 0;
            for (int i = 0; i < N - 2; i++)
            {
                num = Int32.Parse(Console.ReadLine()!);
            }

            if (num2 % num1 == 0)
            {
                Console.Write(num * (num2 / num1));
            }
            else
            {
                Console.Write(num + (num2 - num1));
            }
        }
    }
}
