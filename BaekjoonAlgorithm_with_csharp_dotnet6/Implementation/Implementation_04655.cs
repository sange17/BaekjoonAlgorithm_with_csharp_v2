namespace BaekjoonAlgorithm_with_csharp_dotnet6.Implementation
{
    class Implementation_04655
    {
        public void solve()
        {
            while (true)
            {
                double input = double.Parse(Console.ReadLine()!);
                if (input == 0.00) break;

                double card = 0.0;
                int count = 0;
                while (card < input)
                {
                    count++;
                    card += 1.0 / (count + 1);
                }

                Console.WriteLine(count + " card(s)");
            }
        }
    }
}
