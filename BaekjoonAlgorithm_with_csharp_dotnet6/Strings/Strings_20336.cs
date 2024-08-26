namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_20336
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);

            string[] array = Console.ReadLine()!.Split(' ');

            for (int i = 1; i < n; i++)
            {
                array = Console.ReadLine()!.Split(' ');
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
