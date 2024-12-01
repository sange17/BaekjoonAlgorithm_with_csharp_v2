namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_02153
    {
        public void solve()
        {
            int[] array = new int[2000];

            for (int i = 0; i < array.Length; i++)
                array[i] = i;

            for(int i = 2; i < array.Length; i++)
            {
                if (array[i] == 0) continue;

                for (int j = 2 * i; j < array.Length; j += i)
                    array[j] = 0;
            }

            string line = Console.ReadLine()!;
            int sum = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] >= 65 && line[i] <= 90) sum += line[i] - 64 + 26;
                else if (line[i] >= 97 && line[i] <= 122) sum += line[i] - 96;
            }

            if (array.Contains(sum))
                Console.Write("It is a prime word.");
            else
                Console.Write("It is not a prime word.");
        }
    }
}
