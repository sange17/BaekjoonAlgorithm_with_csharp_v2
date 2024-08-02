namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_06812
    {
        public void solve()
        {
            var ottawaTime = int.Parse(Console.ReadLine()!);

            var offsets = new Dictionary<int, string> {
                            {-300, "Victoria"},
                            {-200, "Edmonton"},
                            {-100, "Winnipeg"},
                            {0, "Toronto"},
                            {100, "Halifax"},
                            {130, "St. John's"}
                          };

            var ottawaHour = ottawaTime / 100;
            var ottawaMin = ottawaTime % 100;

            Console.WriteLine($"{ottawaTime} in Ottawa");
            foreach (var offset in offsets)
            {
                var localHour = (ottawaHour + (offset.Key / 100) + 24) % 24;
                var localMin = (ottawaMin + (offset.Key % 100)) % 60;

                if ((ottawaMin + (offset.Key % 100)) >= 60)
                    localHour = (localHour + 1) % 24;

                if (localHour == 0 && localMin == 0)
                    Console.WriteLine("0 in " + offset.Value);
                else if (localHour != 0 && localMin == 0)
                    Console.WriteLine($"{localHour}00 in {offset.Value}");
                else if (localHour == 0 && localMin != 0)
                    Console.WriteLine($"{localMin} in {offset.Value}");
                else
                    Console.WriteLine($"{localHour}{localMin:D2} in {offset.Value}");
            }

        }
    }
}
