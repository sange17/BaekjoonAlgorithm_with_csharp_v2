namespace BaekjoonAlgorithm_with_csharp_dotnet6.Mathematics
{
    class Mathematics_05342
    {
        public void solve()
        {
            double sum = 0;
            while (true)
            {
                string line = Console.ReadLine()!;

                if (line == "EOI") break;

                if (line == "Paper") sum += 57.99;
                else if (line == "Printer") sum += 120.50;
                else if (line == "Planners") sum += 31.25;
                else if (line == "Binders") sum += 22.50;
                else if (line == "Calendar") sum += 10.95;
                else if (line == "Notebooks") sum += 11.20;
                else if (line == "Ink") sum += 66.95;
            }

            Console.Write("$" + sum);
        }
    }
}
