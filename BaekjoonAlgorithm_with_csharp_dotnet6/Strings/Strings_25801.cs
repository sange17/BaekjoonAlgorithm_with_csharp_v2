namespace BaekjoonAlgorithm_with_csharp_dotnet6.Strings
{
    class Strings_25801
    {
        public void solve()
        {
            char[] chars = Console.ReadLine()!.ToCharArray();

            int[] array = new int[26];

            for (int i = 0; i < chars.Length; i++)
            {
                array[chars[i] - 97]++;
            }

            int cntEven = 0;
            int cntOdd = 0;
            for (int i = 0; i < 26; i++)
            {
                if (array[i] == 0) continue;

                if (array[i] % 2 == 0) cntEven++;
                else if(array[i] % 2 != 0) cntOdd++;
            }

            if(cntEven > 0 &&  cntOdd == 0)
            {
                Console.Write("0");
            }
            else if (cntEven == 0 && cntOdd > 0)
            {
                Console.Write("1");
            }
            else if (cntEven > 0 && cntOdd > 0)
            {
                Console.Write("0/1");
            }
        }
    }
}
