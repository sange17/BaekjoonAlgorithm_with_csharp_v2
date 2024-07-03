namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_24569
    {
        public void solve()
        {
            int n = Int32.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                int point = Int32.Parse(Console.ReadLine());
                int penalty = Int32.Parse(Console.ReadLine());

                if (point * 5 - penalty * 3 > 40)
                {
                    count++;
                }
            }

            if (count == n)
            {
                Console.Write(count + "+");
            }
            else
            {
                Console.Write(count);
            }
        }
    }
}
