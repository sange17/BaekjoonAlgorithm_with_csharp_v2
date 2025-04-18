namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_09907
    {
        public void solve()
        {
            char[] array = Console.ReadLine()!.ToCharArray();
            int sum = (array[0] - 48) * 2
                    + (array[1] - 48) * 7
                    + (array[2] - 48) * 6
                    + (array[3] - 48) * 5
                    + (array[4] - 48) * 4
                    + (array[5] - 48) * 3
                    + (array[6] - 48) * 2;

            int remain = sum % 11;

            if(remain == 0) Console.Write("J");
            if(remain == 1) Console.Write("A");
            if(remain == 2) Console.Write("B");
            if(remain == 3) Console.Write("C");
            if(remain == 4) Console.Write("D");
            if(remain == 5) Console.Write("E");
            if(remain == 6) Console.Write("F");
            if(remain == 7) Console.Write("G");
            if(remain == 8) Console.Write("H");
            if(remain == 9) Console.Write("I");
            if(remain == 10) Console.Write("Z");
        }
    }
}
