namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_33612
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine()!);
            int year = 2024;
            int month = 8;
            month += ((N - 1) * 7);

            if (month % 12 == 0)
            {
                year += (month / 12 - 1);
                month = 12;
            }
            else
            {
                year += (month / 12);
                month %= 12;
            }

            Console.Write(year + " " + month);
        }
    }
}
