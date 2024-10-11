namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_02948
    {
        public void solve()
        {
            string[] date = Console.ReadLine()!.Split(" ");

            DateTime dateTime = DateTime.Parse("2009-" + date[1].PadLeft(2,'0') + "-" + date[0].PadLeft(2,'0'));

            Console.Write(dateTime.DayOfWeek);
        }
    }
}
