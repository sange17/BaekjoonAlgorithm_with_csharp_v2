namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_07218
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine());
            string line = Console.ReadLine();
            string[] array = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X", "XI", "XII" };

            for (int i = 0; i < 12; i++)
            {
                if (line.Contains(array[i]))
                {
                    Console.Write((i + 1) + " ");
                }
            }
        }
    }
}
