namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_06845
    {
        static bool EnableToVote(int year, int month, int day)
        {
            if (year > 2007 || (year == 2007 && month > 2) || (year == 2007 && month == 2 && day > 27))
                return false;

            if (year < 1989 || (year == 1989 && month < 2) || (year == 1989 && month == 2 && day <= 27))
                return true;

            return false;
        }

        public void solve()
        {
            var n = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()!.Split(' ');
                var year = int.Parse(input[0]);
                var month = int.Parse(input[1]);
                var day = int.Parse(input[2]!);

                if (EnableToVote(year, month, day))
                    Console.WriteLine("Yes");
                else Console.WriteLine("No");
            }
        }
    }
}
