namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_16018
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);
            char[] array1 = Console.ReadLine()!.ToCharArray();
            char[] array2 = Console.ReadLine()!.ToCharArray();

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if((array1[i] == array2[i]) && (array1[i] != '.' || array2[i] != '.')) count++;
            }

            Console.Write(count);
        }
    }
}
