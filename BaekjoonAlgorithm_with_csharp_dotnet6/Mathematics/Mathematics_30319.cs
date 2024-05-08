namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_30319
    {
        public void solve()
        {
            DateTime date1 = DateTime.Parse(Console.ReadLine());
            DateTime date2 = DateTime.Parse("2023-10-21");

            if ((date2 - date1).Days >= 35)
            {
                Console.Write("GOOD");
            }
            else
            {
                Console.Write("TOO LATE");
            }
        }
    }
}
