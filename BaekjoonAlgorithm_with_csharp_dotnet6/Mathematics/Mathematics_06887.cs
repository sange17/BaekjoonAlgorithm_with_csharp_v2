namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_06887
    {
        public void solve()
        {
            int N = Int32.Parse(Console.ReadLine());
            int answer = 0;

            int i = 1;
            while (true)
            {
                if (i * i > N) break;

                answer = i;

                i++;
            }

            Console.Write("The largest square has side length " + answer + ".");
        }
    }
}
