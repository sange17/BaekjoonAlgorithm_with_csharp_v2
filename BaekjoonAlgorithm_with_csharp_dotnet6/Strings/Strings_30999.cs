namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_30999
    {
        // 백준 작성 완료
        public void solve()
        {
            string line = Console.ReadLine()!;
            int n = Int32.Parse(line.Split(" ")[0]);
            int m = Int32.Parse(line.Split(" ")[1]);

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                char[] array = Console.ReadLine()!.ToCharArray();

                if (array.Where(x => x == 'O').Count() > array.Length / 2)
                    count++;
            }

            Console.Write(count);
        }
    }
}
