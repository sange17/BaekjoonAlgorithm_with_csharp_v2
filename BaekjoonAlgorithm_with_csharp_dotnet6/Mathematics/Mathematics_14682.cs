namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_14682
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);
            int k = Int32.Parse(Console.ReadLine()!);

            int sum = n;
            for (int i = 0; i < k; i++)
            {
                sum += Int32.Parse(n + "0");
                n = Int32.Parse(n + "0");
            }

            Console.Write(sum);
        }
    }
}
