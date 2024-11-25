namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_01434
    {
        public void solve()
        {
            int[] inputArr = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            int[] boxArr = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            int[] bookArr = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

            for (int i = 0; i < bookArr.Length; i++)
            {
                for (int j = 0; j < boxArr.Length; j++)
                {
                    if (bookArr[i] == 0)
                        continue;

                    if (boxArr[j] >= bookArr[i])
                    {
                        boxArr[j] -= bookArr[i];
                        bookArr[i] = 0;
                        break;
                    }
                }
            }

            Console.Write(boxArr.Sum());
        }
    }
}
