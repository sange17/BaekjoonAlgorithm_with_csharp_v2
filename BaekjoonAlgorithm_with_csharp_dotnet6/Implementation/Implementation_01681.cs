namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_01681
    {
        public void solve()
        {
            int[] inputs = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

            int count = 0;
            int num = 0;

            while (true)
            {
                if (count == inputs[0])
                {
                    Console.Write(num);
                    break;
                }
                else
                {
                    num++;
                }

                if (!num.ToString().Contains(inputs[1].ToString()))
                {
                    count++;
                }
            }
        }
    }
}
