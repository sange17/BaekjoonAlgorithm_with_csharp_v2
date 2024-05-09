namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_27332
    {
        public void solve()
        {
            string a = Console.ReadLine().PadLeft(2, '0');
            int b = Int32.Parse(Console.ReadLine());

            DateTime date = DateTime.Parse(("2022-11-" + a)).AddDays(b * 7);

            if(date.Month == 11)
                Console.Write(1);
            else
                Console.Write(0);
        }
    }
}
