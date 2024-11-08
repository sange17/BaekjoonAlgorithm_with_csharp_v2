namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_02858
    {
        public void solve()
        {
            int[] array = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            Array.Sort(array);
            int sum = array[0] + array[1];

            for (int i = 3; i <= sum / 2; i++)
            {
                if (sum % i == 0)
                {
                    int L = sum / i;    //긴 변
                    int W = i;          //짧은 변
                    if (L * 2 + (W - 2) * 2 + (L - 2) * (W - 2) == sum)
                    {
                        //바깥쪽 > 안쪽
                        if (L * 2 + (W - 2) * 2 == array[1] && (L - 2) * (W - 2) == array[0])
                        {
                            Console.Write(L + " " + W);
                            break;
                        }
                        // 바깥쪽 < 안쪽
                        else if (L * 2 + (W - 2) * 2 == array[0] && (L - 2) * (W - 2) == array[1])
                        {
                            Console.Write(L + " " + W);
                            break;
                        }
                    }
                }
            }
        }
    }
}
