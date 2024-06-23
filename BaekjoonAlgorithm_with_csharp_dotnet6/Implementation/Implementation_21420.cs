namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_21420
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine());

            int front = 0;
            int back = 0;
            for (int i = 0; i < n; i++)
            {
                if (Int32.Parse(Console.ReadLine()) == 0) front++;
                else back++;
            }

            Console.Write(Math.Min(front, back));
        }
    }
}
