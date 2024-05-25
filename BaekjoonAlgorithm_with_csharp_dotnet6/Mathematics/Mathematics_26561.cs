namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_26561
    {
        public void solve()
        {
            int T = Int32.Parse(Console.ReadLine());

            for(int i = 0; i < T; i++)
            {
                string[] arr = Console.ReadLine().Split(" ");
                int population = Int32.Parse(arr[0]);
                int time = Int32.Parse(arr[1]);

                int birth = time / 4;
                int death = time / 7;

                population += (birth - death);
                Console.WriteLine(population);
            }
        }
    }
}
