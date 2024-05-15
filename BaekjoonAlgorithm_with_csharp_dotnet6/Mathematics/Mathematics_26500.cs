namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_26500
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                decimal a = Decimal.Parse(line.Split(" ")[0]);
                decimal b = Decimal.Parse(line.Split(" ")[1]);

                Console.WriteLine("{0:F1}", Math.Abs(a - b));
            }
        }
    }
}
