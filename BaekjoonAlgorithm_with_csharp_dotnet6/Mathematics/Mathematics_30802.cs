namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_30802
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine()!);

            int[] peopleArray = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            int[] tpInput = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            int count = 0;
            for (int i = 0; i < 6; i++)
            {
                count += peopleArray[i] / tpInput[0];

                if (peopleArray[i] % tpInput[0] != 0) count++;
            }

            Console.WriteLine(count);
            Console.Write(n / tpInput[1] + " " + n % tpInput[1]);
        }
    }
}
