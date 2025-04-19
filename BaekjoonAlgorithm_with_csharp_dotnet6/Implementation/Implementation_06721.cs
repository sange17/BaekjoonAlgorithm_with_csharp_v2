namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_06721
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);
            int num1 = 0;
            int num2 = 0;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                char[] array = Console.ReadLine()!.ToCharArray();
                Array.Reverse(array);
                string line = new string(array);

                num1 = Int32.Parse(line.Split(" ")[0]);
                num2 = Int32.Parse(line.Split(" ")[1]);

                sum = num1 + num2;

                array = sum.ToString().ToCharArray();
                Array.Reverse(array);
                line = new string(array);

                Console.WriteLine(Int32.Parse(line));
            }
        }
    }
}
