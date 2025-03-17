namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_32801
    {
        public void solve()
        {
            int[] inputs = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            for (int i = 1; i <= inputs[0]; i++)
            {
                if (i % inputs[1] == 0 && i % inputs[2] == 0)
                    count3++;
                else if (i % inputs[1] == 0)
                    count1++;
                else if (i % inputs[2] == 0)
                    count2++;
            }

            Console.Write(count1 + " " + count2 + " " + count3);
        }
    }
}
