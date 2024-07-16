namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_17284
    {
        public void solve()
        {
            string[] array = Console.ReadLine()!.Split(' ');

            int sum = 0;
            for(int i = 0; i  < array.Length; i++)
            {
                if (array[i] == "1")
                {
                    sum += 500;
                }
                else if (array[i] == "2")
                {
                    sum += 800;
                }
                else if (array[i] == "3")
                {
                    sum += 1000;
                }
            }

            Console.Write(5000 - sum);
        }
    }
}
